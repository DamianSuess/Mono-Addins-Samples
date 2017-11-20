using Mono.Addins;

namespace TestMonoAddins
{
  [TypeExtensionPoint(Path = "/TestApp/StartupHandler")]
  //[TypeExtensionPoint(Path = "/TestApp/StartupHandler", NodeName="StartupHandler")]
  public interface IStartupExtension
  {
    string Title { get; }

    void Run();
  }
}
