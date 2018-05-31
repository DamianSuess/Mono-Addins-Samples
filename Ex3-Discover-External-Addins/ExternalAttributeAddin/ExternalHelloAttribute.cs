using System;
using System.Windows.Forms;
using Mono.Addins;
using TestMonoAddins;

[assembly: Addin]
[assembly: AddinDependency("TestApp", "1.0")]

namespace ExternalAttributeAddin
{
  [Extension(Path = "/TestApp/StartupHandler",
             NodeName = "StartupAddin")]
  public class ExternalHelloAttribute : IStartupExtension
  {
    public ExternalHelloAttribute()
    {
      this.Title = "Title for - External Hello Attribute Add-In";
    }

    public string Title { get; }

    public void Run()
    {
      Console.WriteLine(":: ExternalHelloAttribute.Run()");
      MessageBox.Show("Hello from, external Attribute defined Add-in!", Title);
    }
  }
}
