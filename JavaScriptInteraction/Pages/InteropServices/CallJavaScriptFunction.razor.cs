using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace JavaScriptInteraction.Pages.InteropServices;

[SupportedOSPlatform("browser")]
public partial class CallJavaScriptFunction
{
    public static async Task ImportModuleAsync() => await JSHost.ImportAsync("Collocated Module", "../Pages/InteropServices/CallJavaScriptFunction.razor.js");

    [JSImport("HelloBlazorSchool", "Collocated Module")]
    static partial void CallCollocatedJSModuleFunction();
}
