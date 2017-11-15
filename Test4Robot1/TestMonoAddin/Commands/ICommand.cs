using Mono.Addins;

namespace TestMonoAddin.Commands
{
  [TypeExtensionPoint]
  public interface ICommand
  {
    void Run();
  }
}
