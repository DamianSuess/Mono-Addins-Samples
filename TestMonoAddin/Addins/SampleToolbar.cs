using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMonoAddin.Commands.ExtensionNodes;

[assembly: CustomAttribute(
  Id = "OpenCmd",
  IconFile = "open.png",
  Label = "Open File")]
namespace TestMonoAddin.Addins
{
  class SampleToolbar
  {
  }
}
