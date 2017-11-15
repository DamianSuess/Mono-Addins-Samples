using System;
using System.Windows.Forms;
using Mono.Addins;

namespace TestHostSimple

{
  public partial class Workbench : Form
  {

    public void Initialize()
    {
      // Initialize the editor extensions.
      // Must be done after setting Program.MainWindow since extensions may use it
      //foreach (EditorExtension ext in AddinManager.GetExtensionObjects<EditorExtension>())
      //  ext.Initialize();
    }

    public Workbench()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void DebugPrint(string buff)
    {
      Console.WriteLine(buff);
    }


    //#region MonoAddins
    //
    //private void InitAddins()
    //{
    //  DebugPrint("Init - Started");
    //  AddinManager.Initialize();
    //  AddinManager.Registry.Update();

    //  AddinManager.AddinLoadError += Addin_OnError;
    //  AddinManager.AddinLoaded += Addin_OnLoaded;
    //  AddinManager.AddinLoaded += Addin_OnUnload;
    //  DebugPrint("Init - Exiting");
    //}

    //private void Addin_OnUnload(object sender, AddinEventArgs args)
    //{
    //  Console.WriteLine($"Addin_OnUnload: {args.AddinId}");
    //}

    //private void Addin_OnLoaded(object sender, AddinEventArgs args)
    //{
    //  Console.WriteLine($"Addin_OnLoaded: {args.AddinId}");
    //}

    //private void Addin_OnError(object sender, AddinErrorEventArgs args)
    //{
    //  Console.WriteLine($"Addin_OnError: Id[{args.AddinId}]; Message[{args.Message}]; Exception[{args.Exception}]");
    //}

    //private void LoadExtensions()
    //{
    //  //GetCommandEntrySet("/RedRock/UI/MainMenu");
    //  GetExtNodes("/RedRock/UI/ToolbarButtons");
    //  //GetExtNodes("/RedRock/UI/MainMenu");
    //  //GetExtPoints();
    //}

    //private void GetCommandEntrySet(string addinPath)
    //{
    //  DebugPrint($"CommandEntry [{addinPath}] (");

    //  CommandEntrySet cmdSet = new CommandEntrySet();
    //  object[] items = AddinManager.GetExtensionObjects(addinPath, false);
    //  foreach (CommandEntry item in items)
    //  {
    //    DebugPrint("* Got an CommandEntry: " + item.ToString());
    //    cmdSet.Add(item);
    //  }

    //  //return cmdSet;
    //  DebugPrint(") CommandEntry");
    //}

    //private void GetExtNodes(string addinPath)
    //{
    //  DebugPrint($"Nodes [{addinPath}] (");

    //  foreach (var item in AddinManager.GetExtensionNodes(addinPath))
    //  {
    //    DebugPrint("* Got an Ext Node: " + item.ToString());
    //  }

    //  DebugPrint(") Nodes");
    //}

    //private void GetExtPoints()
    //{
    //  DebugPrint("Points {");
    //  foreach (ICommand cmd in AddinManager.GetExtensionObjects<ICommand>())
    //  {
    //    DebugPrint(" * Got an Ext Point: " + cmd.ToString());
    //    cmd.Run();
    //  }
    //  DebugPrint("} Points");
    //}
    //
    //#endregion MonoAddins
  }
}
