using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoAddin.Commands
{
  public class CommandEntrySet : CommandEntry, IEnumerable<CommandEntry>
  {
    List<CommandEntry> _commands = new List<CommandEntry>();

    public CommandEntrySet() : base((object)null) { }

    public string Name { get; set; }

    public string Icon { get; set; }

    public bool AutoHide { get; set; }

    public void Add(CommandEntry entry)
    {
      // If it's just a CommandEntry then add it to the set
      var cmdSet = entry as CommandEntrySet;
      if (cmdSet == null)
      {
        _commands.Add(entry);
        return;
      }

      foreach(var tmpEntry in _commands)
      {
        if (Equals(tmpEntry.CommandId, entry.CommandId))
        {
          var entrySet = entry as CommandEntrySet;
          if (entrySet == null)
            continue;

          entrySet._commands.AddRange(cmdSet);
          return;
        }
      }

      // No duplicates found, add it!
      _commands.Add(entry);
    }

    //public void AddSeparator()
    //{
    //  AddItem(Command.Separator);
    //}
    public int Count
    {
      get { return _commands.Count; }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return _commands.GetEnumerator();
    }

    IEnumerator<CommandEntry> IEnumerable<CommandEntry>.GetEnumerator()
    {
      return _commands.GetEnumerator();
    }
  }
}
