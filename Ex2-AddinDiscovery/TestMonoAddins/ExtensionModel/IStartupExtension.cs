using Mono.Addins;

namespace TestMonoAddins
{
  [TypeExtensionPoint(Path = "/TestApp/StartupHandler")]
  public interface IStartupExtension
  {
    string Title { get; }

    void Run();
  }
}
