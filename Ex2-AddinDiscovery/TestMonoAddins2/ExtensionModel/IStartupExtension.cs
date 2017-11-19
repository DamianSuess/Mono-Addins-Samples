﻿//using Mono.Addins;

//[assembly: ExtensionPoint("/TestApp/StartupHandler")]
using Mono.Addins;

namespace TestMonoAddins2
{
  [TypeExtensionPoint(Path = "/TestApp/StartupHandler")]
  public interface IStartupExtension
  {
    string Title { get; }

    void Run();
  }
}
