using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace JavaScriptInteraction.Pages.InteropServices;

[SupportedOSPlatform("browser")]
public partial class CallJavaScriptFunction
{
    [JSImport("HelloBlazorSchool", "GlobalJSModule")]
    static partial void CallCollocatedJSModuleFunction();
}
