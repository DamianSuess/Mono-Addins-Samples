using Mono.Addins;

namespace TestMonoAddins
{
  [TypeExtensionPoint(Path = "/TestApp/StartupHandler",
                      NodeName = "StartupAddin")]
  public interface IStartupExtension
  {
    string Title { get; }

    void Run();
  }
}
