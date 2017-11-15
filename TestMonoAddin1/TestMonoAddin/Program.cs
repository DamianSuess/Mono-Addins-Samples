using System;
using System.Windows.Forms;

namespace TestMonoAddin
{
  internal static class Program
  {
    public static Form1 MainWindow { get; set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      //MainWindow = new Form1();
      //MainWindow.Initialize();    // Init extensions
      //Application.Run(MainWindow);

      Application.Run(new Form1());
    }
  }
}
