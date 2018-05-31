using System;
using System.Windows.Forms;
using Mono.Addins;

namespace TestMonoAddins.InternalAddin
{
  [Extension("/TestApp/StartupHandler")]
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
