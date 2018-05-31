using System;
using System.Windows.Forms;
using Mono.Addins;

namespace TestMonoAddins.InternalAddin
{
  // The following Attribute is defined in XML
  //[Extension("/TestApp/StartupHandler")]
  public class SampleStartupExtension : IStartupExtension
  {
    public SampleStartupExtension()
    {
      this.Title = "Sample Startup Add-In";
    }

    public string Title { get; }

    public void Run()
    {
      Console.WriteLine("Sample Startup :: Run");
      MessageBox.Show("Sample Startup Add-in!");
    }
  }
}
