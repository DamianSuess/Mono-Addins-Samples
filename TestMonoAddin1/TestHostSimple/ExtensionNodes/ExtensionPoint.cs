using Mono.Addins;
using TestHostSimple.ExtensionNodes;

//[assembly: ExtensionPoint("/RobotUI/ToolbarButtons", Node = "Main toolbar", NodeName = "Button", ExtensionAttributeType = typeof(ToolButtonAttribute))]
//[assembly: ExtensionPoint("/RobotUI/Toolbar", NodeName = "Button", ExtensionAttributeType = typeof(ToolButtonAttribute))]
//[assembly: ExtensionPoint("/RobotUI/Toolbar", NodeName = "Separator", ExtensionAttributeType = typeof(SeparatorAttribute))]

[assembly: ExtensionPoint ("/RobotUI/MainMenu", NodeName="Menu", NodeType = typeof(MainMenuExtensionNode))]
