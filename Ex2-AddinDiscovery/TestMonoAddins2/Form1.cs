using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using Mono.Addins;

[assembly: AddinRoot("RobotUI", "1.0")]

namespace TestMonoAddins2
{
  public partial class Form1 : Form
  {
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    private string StartupExtensionPath = "/RobotUI/StartupHandler";

    public Form1()
    {
      InitializeComponent();

      Mono.Addins.AddinManager.Initialize(".");
      Mono.Addins.AddinManager.Registry.Update();

      Mono.Addins.AddinManager.AddExtensionNodeHandler(
        StartupExtensionPath,
        StartupHandler_ExtensionChanged);
    }

    private void BtnPullAppAddins_Click(object sender, EventArgs e)
    {
      LogDebug("Available Startup Handlers {");


      //foreach (IStartupExtension cmd in
      //        AddinManager.GetExtensionObjects<IStartupExtension>())
      //{
      //  cmd.Run();
      //}

      var exts = AddinManager.GetExtensionObjects<IStartupExtension>(true);
      foreach (IStartupExtension ext in exts)
      {
        string title = ext.Title;
        ext.Run();

        LogDebug("  Title: " + title);
      }

      LogDebug("}");
      // Use this to access custom Attributes
      //int count = 0;
      //ExtensionNodeList nodes = AddinManager.GetExtensionNodes(StartupExtensionPath);
      //ExtensionNodeList nodes = AddinManager.GetExtensionNodes(typeof(IStartupExtension));
      //foreach (TypeExtensionNode<IStartupAttribute> ext in nodes)
      //{
      //  ++count;
      //  LogDebug($"[{count}]  Id: {ext.Id} Title: '{ext.Data.Title}'");
      //}
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
      Log.Debug(msg);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
  }
}
