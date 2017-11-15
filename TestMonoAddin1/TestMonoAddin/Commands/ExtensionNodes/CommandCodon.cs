using System;
using Mono.Addins;

namespace TestMonoAddin.Commands.ExtensionNodes
{
  public enum ActionType
  {
    Normal,
    Check,
    Radio
  }

  [ExtensionNode(Description =
    "A user interface command. The 'id' of the command must match the full name of an existing enumeration. " +
    "An arbitrary string can also be used as an id for the command by just using '@' as prefix for the string.")]
  internal class CommandCodon : TypeExtensionNode
  {
    [NodeAttribute("_label", true, "Label", Localizable = true)]
    public string Label { get; set; }

    [NodeAttribute("_displayName", "Display Name of the command, visible in search results or key bindings option panel.", Localizable = true)]
    public string DisplayName { get; set; }

    [NodeAttribute("_description", "Description of the command", Localizable = true)]
    public string Description { get; set; }

    [NodeAttribute("shortcut", "Key combination that triggers the command. Control, Alt, Meta, Super and Shift modifiers can be specified using '+' as a separator. Multi-state key bindings can be specified using a '|' between the mode and accel. For example 'Control+D' or 'Control+X|Control+S'")]
    public string Shortcut { get; set; }

    [NodeAttribute("macShortcut", "Mac version of the shortcut. Format is that same as 'shortcut', but the 'Meta' modifier corresponds to the Command key.")]
    public string MacShortcut { get; set; }

    [NodeAttribute("winShortcut", "Win version of the shortcut. Format is that same as 'shortcut'.")]
    public string WinShortcut { get; set; }

    [NodeAttribute("icon", "Icon of the command. The provided value must be a registered stock icon. A resource icon can also be specified using 'res:' as prefix for the name, for example: 'res:customIcon.png'")]
    public string Icon { get; set; }

    [NodeAttribute("disabledVisible", "Set to 'false' if the command has to be hidden when disabled. 'true' by default.")]
    public bool DisabledVisible = true;

    [NodeAttribute("type", "Type of the command. It can be: normal (the default), check, radio or array.")]
    public string type = "normal";

    [NodeAttribute("widget", "Class of the widget to create when type is 'custom'.")]
    public string Widget = null;

    [NodeAttribute("defaultHandler", "Class that handles this command. This property is optional.")]
    public string DefaultHandler { get; set; }


    public override object CreateInstance()
    {

      Console.WriteLine("CommandCodon.CreateInstance");

      ActionType action = ActionType.Normal;

      return base.CreateInstance();
    }
  }
}
