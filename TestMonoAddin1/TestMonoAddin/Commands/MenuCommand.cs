using System;
using Mono.Addins;

namespace TestMonoAddin.Commands
{
  [Extension(Path = "/RedRock/UI/MainMenu")]
  public class MenuCommand : ICommand
  {
    public void Run()
    {
      Console.WriteLine("Menu command executed!");
    }
  }
}
