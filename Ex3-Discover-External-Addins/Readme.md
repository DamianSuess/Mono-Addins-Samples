# Example 3

## In this Example

1. The **ExtensionPoint** is defined using a class **attribute**.
2. We are introducing 2 **external add-in** DLLs, and 1 internal add-in.
    * ExternalAttributeAddin - _Registers itself using class attributes._
    * ExternalXmlAddin - _Registers itself using an XML manifest._
    * InternalAttributeAddin - _Registers iteself using class attributes._
3. We're **re-executing** via WinForm button click.

## What's New?

Since the host is defining the **ExtensionPoint** via class attributes and we're also using an external DLL via XML manifest, you MUST define the **NodeName**. Otherwise, the system will get confused on what Type to assign.

## Querying Add-ins

From the book of [Mono.Addins Wiki](https://github.com/mono/mono-addins/wiki/Handling-Add-ins-at-Run-time): 
> It is important to notice that getting the extensions of a node won't normally result in loading any add-in. The add-in engine is able to extract the needed information from add-ins without having to load them.
>
> The nodes returned from GetExtensionNodes will have the actual node type, depending on the node name that was used by add-ins to register them.


## Querying Extension Nodes
Since we defined our ExtensionNode via Path, we **MUST** query it via path (_/TestApp/StartupHandler_). Otherwise it will attempt to find it from the assembly namespace (_IStartupExtension_) and won't find it.

```
foreach (TypeExtensionNode node in AddinManager.GetExtensionNodes(StartupExtensionPath))
{
  IStartupExtension ext = (IStartupExtension)node.CreateInstance();
  ext.Run();
}
```

### Does Not Work (in this example)
If we defined our ExtensionPoint without specifying the aforementioned path, then we would use the following.
```
foreach (TypeExtensionNode node in AddinManager.GetExtensionNodes(typeof(IStartupExtension)))
{
  IStartupExtension ext = (IStartupExtension)node.CreateInstance();
  ext.Run();
}
```
