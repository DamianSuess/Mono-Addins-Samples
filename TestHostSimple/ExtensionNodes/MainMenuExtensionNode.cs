using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mono.Addins;

namespace TestHostSimple.ExtensionNodes
{
  [ExtensionNode("Menu")]
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
