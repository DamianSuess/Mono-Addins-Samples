using System.Windows.Forms;
using TestMonoAddins;

namespace ExternalStartupXmlAddin
{
  public class HelloXML : IStartupExtension
  {
    public HelloXML()
    {
      Title = "External Hello XML Add-in";
    }

    public string Title { get; }

    public void Run()
    {
      MessageBox.Show("Hello from XML defined Add-in!");
    }
  }
}