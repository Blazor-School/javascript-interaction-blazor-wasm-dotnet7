using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace JavaScriptInteraction.InteropServicesModules;

[SupportedOSPlatform("browser")]
public partial class GlobalJavaScriptModule
{
    [JSImport("HelloBlazorSchool", "Global Module")]
    public static partial void HelloBlazorSchool();
}
