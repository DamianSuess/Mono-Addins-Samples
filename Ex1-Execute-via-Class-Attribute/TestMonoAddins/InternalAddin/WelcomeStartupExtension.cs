﻿using System;
using System.Windows.Forms;
using Mono.Addins;

namespace TestMonoAddins.InternalAddin
{
  [Extension("/TestApp/StartupHandler")]
  public class WelcomeStartupExtension : IStartupExtension
  {
    public WelcomeStartupExtension()
    {
      this.Title = "Welcome Add-In";
    }

    public string Title { get; }

    public void Run()
    {
      Console.WriteLine("Welcome Startup :: Run");
      MessageBox.Show("Welcome Add-in!");
    }
  }
}
