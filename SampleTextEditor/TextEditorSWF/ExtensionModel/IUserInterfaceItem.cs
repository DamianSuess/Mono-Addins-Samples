using System.Windows.Forms;

namespace TextEditorSWF.ExtensionModel
{
  /// <summary>
  /// An extension node which can be used to create toolbar or menu items.
  /// </summary>
  internal interface IUserInterfaceItem
  {
    /// <summary>
    /// Creates a menu item for the node
    /// </summary>
    ToolStripItem CreateMenuItem();

    /// <summary>
    /// Creates a toolbar button for the node
    /// </summary>
    ToolStripItem CreateButton();
  }
}
