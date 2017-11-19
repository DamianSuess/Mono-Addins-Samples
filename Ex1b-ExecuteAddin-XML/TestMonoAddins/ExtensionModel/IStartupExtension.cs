using Mono.Addins;

namespace TestMonoAddins
{
  // The following Attribute is defined in XML
  //[TypeExtensionPoint(Path = "/TestApp/StartupHandler")]
  public interface IStartupExtension
  {
    string Title { get; }

    void Run();
  }
}
