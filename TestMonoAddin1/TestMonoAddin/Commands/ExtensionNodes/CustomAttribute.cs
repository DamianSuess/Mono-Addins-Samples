using Mono.Addins;

namespace TestMonoAddin.Commands.ExtensionNodes
{
  // ToolButtonAttribute 
  public class CustomAttribute : CustomExtensionAttribute
  {
    [NodeAttribute]
    public string IconFile { get; set; }

    [NodeAttribute]
    public string IconResource { get; set; }

    [NodeAttribute]
    public string Label { get; set; }

    public CustomAttribute() { }

    public CustomAttribute([NodeAttribute("Label")] string label)
    {
      Label = label;
    }
  }

}
