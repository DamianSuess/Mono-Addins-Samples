using System;
using Mono.Addins;
using TestMonoAddin.Commands;

[assembly: Addin]
[assembly: AddinDependency("RedRock", "1.0")]

namespace TestMonoAddin.SampleAddin
{
  public class Sample1 : ICommand
  {
    public void Run()
    {
      Console.WriteLine("Sample AddIn #1 Running!");
    }
  }
}
