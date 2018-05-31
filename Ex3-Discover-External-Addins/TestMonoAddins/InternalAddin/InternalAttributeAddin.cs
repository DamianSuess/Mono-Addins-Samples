using System;
using System.Windows.Forms;
using Mono.Addins;

namespace TestMonoAddins.InternalAddin
{
  [Extension(Path = "/TestApp/StartupHandler",
             NodeName = "StartupAddin")]
  public class InternalAttributeAddin : IStartupExtension
  {
    public InternalAttributeAddin()
    {
      this.Title = "Internal Welcome Add-In";
    }

    public string Title { get; }

    public void Run()
    {
      Console.WriteLine(":: InternalAttributeAddin.Run()");
      MessageBox.Show("Hello from, internal attribute defined Add-in!", Title);
    }
  }
}
