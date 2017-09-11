using System;
using System.Windows.Forms;
using Mono.Addins;

[assembly: AddinRoot(Id = "Core",
                     Version = "1.0",
                     Namespace = "RobotUI")]

namespace TestHostSimple
{
  internal static class Program
  {
    public static Workbench MainWindow { get; private set; }

    /// <summary>The main entry point for the application.</summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      MainWindow = new Workbench();
      MainWindow.Initialize();

      Application.Run(MainWindow);
    }
  }
}
