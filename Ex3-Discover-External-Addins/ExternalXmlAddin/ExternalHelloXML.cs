using System;
using System.Windows.Forms;
using TestMonoAddins;

namespace ExternalStartupXmlAddin
{
  public class ExternalHelloXML : IStartupExtension
  {
    public ExternalHelloXML()
    {
      Title = "Title for - External Hello XML Add-in";
    }

    public string Title { get; }

    public void Run()
    {
      Console.WriteLine(":: ExternalHelloAttribute.Run()");
      MessageBox.Show("Hello from, external XML defined Add-in!");
    }
  }
}