## Example 1 - System.Attribute

In this example we are defining the add-in information using, C# **System.Attribute**.

Note: our root is, "TestApp" and the ExtensionPoint is, "/TestApp/StartupHandler".

## XML vs Attribute Based Definitions
This project has a **"TestMonoAddins.addin.xml"** with the build action set to, **"Embedded Resource"**.

Overall this XML-based example is still doing the same as the other "Example1", which is using _Attribute_ based add-in definitions. I commented out the class and assembly Attributes as a reference point for our XML.


### Inside the Code

1. Our _TestMonoAddins_ project is the **AddinRoot** with the name, _"TestApp"_ and version, _"1.0"_.
2. Interface _IStartupExtension_ is our **ExtensionPoint** for add-ins to consume.
3. And our **Extension** add-in is the class _WelcomStartupExtension_ which derives from our interface.

