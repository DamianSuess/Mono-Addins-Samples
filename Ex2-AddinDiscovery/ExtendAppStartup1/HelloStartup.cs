using System;
using System.Windows.Forms;
using Mono.Addins;
using TestMonoAddins;

[assembly: Addin]
[assembly: AddinDependency("TestApp", "1.0")]

namespace ExtendAppStartup1
{
  [Extension("/TestApp/StartupHandler")]
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
      MessageBox.Show("External Hello Startup from outside DLL", Title);
    }
  }
}
