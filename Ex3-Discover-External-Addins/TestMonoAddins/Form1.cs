using System;
using System.Windows.Forms;
using Mono.Addins;

[assembly: AddinRoot("TestApp", "1.0")]

namespace TestMonoAddins
{
  public partial class Form1 : Form
  {
    private string StartupExtensionPath = "/TestApp/StartupHandler";

    #region Gui Handlers

    public Form1()
    {
      InitializeComponent();

      InitMonoAddins();
    }

    private void BtnPullAppAddins_Click(object sender, EventArgs e)
    {
      AddinExecute();
      TestAddinDiscovery();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    #endregion Gui Handlers

    #region Add-in Handlers

    private void AddinExecute()
    {
      Log.Debug("************************");
      Log.Debug("Add-in Execute");
      Log.Debug("{");

      // Get title and execute add-in
      foreach (TypeExtensionNode node in AddinManager.GetExtensionNodes(StartupExtensionPath))
      {
        IStartupExtension ext = (IStartupExtension)node.CreateInstance();
        Log.Debug($"  Running add-in titled, '{ext.Title}'");

        // Execute add-in
        ext.Run();

        foreach (NodeElement nloc in node.ChildNodes)
        {
          MessageBox.Show("HEY! " + nloc.NodeName);
        }
      }

      Log.Debug("}");
      Log.Debug("* * * * * * * * * * * * *");
    }

    private void InitMonoAddins()
    {
      Log.Debug("Initializing system ...");

      Mono.Addins.AddinManager.AddinLoaded += OnAddinLoaded;
      Mono.Addins.AddinManager.AddinUnloaded += OnAddinUnloaded;

      Mono.Addins.AddinManager.Initialize(".");
      Mono.Addins.AddinManager.Registry.Rebuild(null);  // Rebuild registry when debugging
      //Mono.Addins.AddinManager.Registry.Update();     // Normally just use this
      Mono.Addins.AddinManager.AddExtensionNodeHandler(StartupExtensionPath, OnStartupExtensionChanged);
    }

    private void OnAddinLoaded(object sender, Mono.Addins.AddinEventArgs args)
    {
      Log.Debug($"=============================");
      Log.Debug($"OnAddinLoaded: {args.AddinId}");
      Mono.Addins.Addin addin = Mono.Addins.AddinManager.Registry.GetAddin(args.AddinId);

      Log.Debug($"         Name: '{addin.Name}'");
      Log.Debug($"  Description: '{addin.Description.Description}'");
      Log.Debug($"    Namespace: '{addin.Namespace}'");
      Log.Debug($"      Enabled: '{addin.Enabled}'");
      Log.Debug($"         File: '{addin.AddinFile}'");
      Log.Debug("= = = = = = = = = = = = =");
    }

    private void OnAddinUnloaded(object sender, Mono.Addins.AddinEventArgs args)
    {
      Log.Debug($"OnAddinUnloaded: {args.AddinId}");
    }

    private void OnStartupExtensionChanged(object sender, Mono.Addins.ExtensionNodeEventArgs args)
    {
      Log.Debug("###########################");
      Log.Debug("OnStartChanged {");
      Log.Debug($"  Id      - '{args.ExtensionNode.Id}'");
      Log.Debug($"  Path    - '{args.Path}'");
      Log.Debug($"  Node    - '{args.ExtensionNode}'");
      Log.Debug($"  Object  - '{args.ExtensionObject}'");
      Log.Debug($"  Changed - '{args.Change.ToString()}'");

      Mono.Addins.TypeExtensionNode extNode = args.ExtensionNode as Mono.Addins.TypeExtensionNode;
      Log.Debug("   --[ ExtensionNode ]------");
      Log.Debug($"  Id      - '{extNode.Id}'");
      Log.Debug($"  ToString- '{extNode.ToString()}'");
      Log.Debug($"  TypeName- '{extNode.TypeName}'");
      Log.Debug("# # # # # # # # # # #");

      Log.Debug("  Running...");
      IStartupExtension ext = (IStartupExtension)args.ExtensionObject;
      ext.Run();

      Log.Debug("}");
    }

    private void TestAddinDiscovery()
    {
      //foreach(TypeExtensionNode<IStartupExtension> node in AddinManager.GetExtensionNodes<>)
      //IStartupExtension[] exts = AddinManager.GetExtensionObjects<IStartupExtension>(true);
      //foreach (IStartupExtension ext in exts)
      //{
      //  string title = ext.Title;
      //  ext.Run();
      //  Log.Debug("  Title: " + title);
      //}
    }

    #endregion Add-in Handlers
  }
}
