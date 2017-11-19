## Example 1 - System.Attribute

In this example we are defining the add-in information using an external **XML** file versus Attributes.

Note: our root is, "TestApp" and the ExtensionPoint is, "/TestApp/StartupHandler".

## XML vs Attribute Based Definitions
This project has a **"TestMonoAddins.addin.xml"** with the build action set to, **"Embedded Resource"**.

Overall this XML-based example is still doing the same as the other "Example1", which is using _Attribute_ based add-in definitions. I commented out the class and assembly Attributes as a reference point for our XML.


### Inside the Code

1. Our _TestMonoAddins_ project is the **AddinRoot** with the name, _"TestApp"_ and version, _"1.0"_.
2. Interface _IStartupExtension_ is our **ExtensionPoint** for add-ins to consume.
3. And our **Extension** add-in is the class _WelcomStartupExtension_ which derives from our interface.


### Inside the XML

1. We're defining our AddinRoot in the first line.
2. Define our **ExtensionPoint** with the path, _"/TestApp/StartupHandler"_.
3. Create an **ExtensionNode** for the _ExtensionPoint_.
    * We're naming ours, "StartupHandler" (_this can be named anything_).
    * Point it to our base object **IStartupExtension**. Must use the full assembly name.
4. Lastly we're pointing our "Welcome" Addin to our ExtensionPoint.
    * Must specify which Extension we're hooking to via **Path=**
    * Using the ExtensionNode "Name=" from earlier (

```
<Addin namespace="TestApp" id="TestApp" version="1.0" isroot="true" compatVersion="1.0">
  <Runtime>
    <Import Assembly="TestMonoAddins.exe" />
  </Runtime>
  
  <ExtensionPoint path="/TestApp/StartupHandler">
		<ExtensionNode name="StartupHandler" objectType="TestMonoAddins.IStartupExtension" />
	</ExtensionPoint>

  <!-- Built-in Add-ins -->
  <Extension path="/TestApp/StartupHandler">
    <StartupHandler type="TestMonoAddins.InternalAddin.WelcomeStartupExtension" />
  </Extension>
</Addin>
```

## Example Naming
Your ExtensionNode's **name** can be anything. The code below works the same as above, note use usage of **SOME_NAME** in pace of **StartupHandler**.

```
  <ExtensionPoint path="/TestApp/StartupHandler">
		<ExtensionNode name="SOME_NAME" objectType="TestMonoAddins.IStartupExtension" />
	</ExtensionPoint>

  <!-- Built-in Add-ins -->
  <Extension path="/TestApp/StartupHandler">
    <SOME_NAME type="TestMonoAddins.InternalAddin.WelcomeStartupExtension" />
  </Extension>
```
