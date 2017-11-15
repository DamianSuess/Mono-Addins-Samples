using System;
using Mono.Addins;

namespace TestMonoAddin.Commands.ExtensionNodes
{
  [ExtensionNode(Description = "A SubMenu")]
  internal class ItemSetCondon : InstanceExtensionNode
  {
    private string _label;

    [NodeAttribute("_label", "Label of the SubMenu", Localizable = true)]
    public string Label
    {
      get
      {
        return _label ?? Id;
      }
      set
      {
        _label = value;
      }
    }

    [NodeAttribute("icon", "Icon of the submenu. The provided value must be a registered stock icon. A resource icon can also be specified using 'res:' as prefix for the name, for example: 'res:customIcon.png'")]
    public string Icon { get; set; }

    [NodeAttribute("autohide", "Whether the submenu should be hidden when it contains no items.")]
    public bool AutoHide { get; set; }

    public override object CreateInstance()
    {
      Console.WriteLine("ItemSetCondon.CreateInstance");

      if (_label == null)
        _label = Id;

      //if (Icon != null)
      //  Icon = CommandCodon.GetStockId(Addin, Icon);

      //CommandEntrySet entrySet = new CommandEntrySet(Label, Icon);

      foreach (InstanceExtensionNode node in ChildNodes)
      {
        Console.WriteLine("ItemSetCondon.ChildNode: " + node.ToString());
        //CommandEntry entry = node.CreateInstance() as CommandEntry;
        //if (entry != null)
        //  entrySet.Add(entry);
        //else
        //  throw new InvalidOperationException("Invalid ItemSet child: " + node);
      }

      return null;
      // throw new NotImplementedException();
    }
  }
}
