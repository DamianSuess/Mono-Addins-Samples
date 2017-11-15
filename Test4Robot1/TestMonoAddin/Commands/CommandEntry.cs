namespace TestMonoAddin.Commands
{
  public enum CommandEntryDisplayType
  {
    Default,
    TextOnly,
    IconOnly,
    IconHasPriority,
    IconAndText
  }

  public class CommandEntry
  {
    private object _commandId;

    public CommandEntry() : this(null)
    {
    }

    public CommandEntry(object commandId)
    {
      _commandId = commandId;
    }

    public object CommandId { get; set; }

    public bool DisableVisible { get; set; }

    public string OverrideLabel { get; set; }

    public CommandEntryDisplayType DisplayType { get; set; }

    //public virtual Command GetCommand(CommandManager manager) { ... }
    // internal virtual void CreateMenuItem(CommandManager manager) { ... }
    // internal virtual void CreateToolItem(CommandManager manager) { ... }
  }
}
