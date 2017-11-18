using System;
using System.Windows.Forms;
using Mono.Addins;
using TestMonoAddins2;

[assembly: Addin]
[assembly: AddinDependency("RobotUI", "1.0")]

namespace ExtendAppStartup1
{
  public class HelloStartup : IStartupExtension
  {
    public HelloStartup()
    {
      this.Title = "External Hello Add-In";
    }

    public string Title { get; }

    public void Run()
    {
      Console.WriteLine("Hello Startup :: Run");
      MessageBox.Show("Hello Startup from outside DLL", "External Add-in");
    }
  }
}
