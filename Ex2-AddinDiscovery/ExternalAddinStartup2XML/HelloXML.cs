using System.Windows.Forms;
using TestMonoAddins;

namespace ExternalAddinStartup2XML
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