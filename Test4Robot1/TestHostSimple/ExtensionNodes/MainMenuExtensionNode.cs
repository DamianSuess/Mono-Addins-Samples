using System.Windows.Forms;
using Mono.Addins;

namespace TestHostSimple.ExtensionNodes
{
  [ExtensionNode("Menu")]
  [ExtensionNodeChild(typeof(CommandItemExtensionNode))]
  [ExtensionNodeChild(typeof(SeparatorExtensionNode))]
  public class MainMenuExtensionNode : ExtensionNode  //, IUserInterfaceItem
  {
    [NodeAttribute("Label")]
    public string Label { get; set; }

    /// <summary>Create main menu item</summary>
    /// <returns></returns>
    public ToolStripItem CreateMenuItem()
    {
      ToolStripMenuItem item = new ToolStripMenuItem(Label);

      return item;
    }

    /// <summary>Create sub-menu item</summary>
    /// <returns></returns>
    public ToolStripItem CreateButton()
    {
      return new ToolStripDropDownButton();
    }

  }
}
