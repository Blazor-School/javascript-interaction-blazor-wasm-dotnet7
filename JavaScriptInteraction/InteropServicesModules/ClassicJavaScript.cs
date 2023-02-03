using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace JavaScriptInteraction.InteropServicesModules;

/// <summary>
/// The following class is the wrapper of the GlobalClassicJavaScript.js.
/// The classic JavaScript file is imported in index.html
/// </summary>
[SupportedOSPlatform("browser")]
public partial class ClassicJavaScript
{
    [JSImport("globalThis.HelloBlazorSchool")]
    public static partial void HelloBlazorSchool();
}
