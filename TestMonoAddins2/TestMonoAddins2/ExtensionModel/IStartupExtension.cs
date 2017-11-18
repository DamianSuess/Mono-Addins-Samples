//using Mono.Addins;

//[assembly: ExtensionPoint("/RobotUI/StartupHandler")]
using Mono.Addins;

namespace TestMonoAddins2
{
  [TypeExtensionPoint(Path = "/RobotUI/StartupHandler")]
  public interface IStartupExtension
  {
    string Title { get; }

    void Run();
  }
}
