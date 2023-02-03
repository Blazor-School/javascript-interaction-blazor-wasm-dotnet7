using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace JavaScriptInteraction.InteropServicesModules;

/// <summary>
/// The following class is the wrapper of the JavaScriptModule.js.
/// </summary>
[SupportedOSPlatform("browser")]
public partial class JavaScriptModule
{
    [JSImport("HelloBlazorSchool", "MyModule")]
    public static partial void HelloBlazorSchool();

    [JSImport("PredictableFunction", "MyModule")]
    public static partial string PredictableFunction();

    [JSImport("UnpredictableFunction", "MyModule")]
    public static partial string UnpredictableFunction();

    [JSImport("FunctionWithPrimitiveParameters", "MyModule")]
    public static partial string AutoMarshallingFunctionWithPrimitiveParameters(string param1, int param2,[JSMarshalAs<JSType.Date>] DateTime param3);
}
