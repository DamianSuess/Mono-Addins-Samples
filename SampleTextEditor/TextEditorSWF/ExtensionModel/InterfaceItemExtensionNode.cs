using System.Windows.Forms;
using Mono.Addins;

namespace TextEditorSWF.ExtensionModel
{
  /// <summary>
  /// Extension node that represents a menu or toolbar item.
  /// </summary>
  [ExtensionNode("Command")]
  class InterfaceItemExtensionNode : ExtensionNode, IUserInterfaceItem
  {
    public ToolStripItem CreateMenuItem()
    {
      CommandExtensionNode cmd = CommandManager.GetCommand(Id);
      return cmd.CreateMenuItem();
    }

    public ToolStripItem CreateButton()
    {
      CommandExtensionNode cmd = CommandManager.GetCommand(Id);
      return cmd.CreateButton();
    }
  }
}
