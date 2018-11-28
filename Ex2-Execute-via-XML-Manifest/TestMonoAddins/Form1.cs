using System;
using System.Windows.Forms;

// The following Attribute is defined in XML
//[assembly: AddinRoot("TestApp", "1.0")]

namespace TestMonoAddins
{
  public partial class Form1 : Form
  {
    private string StartupExtensionPath = "/TestApp/StartupHandler";

    public Form1()
    {
      InitializeComponent();

      Mono.Addins.AddinManager.Initialize(".");
      Mono.Addins.AddinManager.Registry.Update();

      Mono.Addins.AddinManager.AddExtensionNodeHandler(
        StartupExtensionPath,
        StartupHandler_ExtensionChanged);
    }

    private void StartupHandler_ExtensionChanged(object sender, Mono.Addins.ExtensionNodeEventArgs args)
    {
      LogDebug("OnStartChanged {");
      LogDebug($"  Path    - {args.Path}");
      LogDebug($"  Node    - {args.ExtensionNode}");
      LogDebug($"  Object  - {args.ExtensionObject}");
      LogDebug($"  Changed - {args.Change.ToString()}");

      Mono.Addins.TypeExtensionNode extNode = args.ExtensionNode as Mono.Addins.TypeExtensionNode;
      LogDebug($"  ExtNode: {extNode.ToString()}");

      LogDebug("  Running...");
      IStartupExtension ext = (IStartupExtension)args.ExtensionObject;
      ext.Run();

      LogDebug("}");
    }

    private void LogDebug(string msg)
    {
      Console.WriteLine(msg);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
  }
}
