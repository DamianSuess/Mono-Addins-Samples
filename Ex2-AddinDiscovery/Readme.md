## In this Example
1. We are introducing an **external add-in** DLL file.
2. We're **re-executing** via WinForm button click.

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
