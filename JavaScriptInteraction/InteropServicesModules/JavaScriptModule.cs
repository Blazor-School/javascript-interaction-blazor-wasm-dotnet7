using JavaScriptInteraction.Models;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace JavaScriptInteraction.InteropServicesModules;

/// <summary>
/// The following class is the wrapper of the JavaScriptModule.js.
/// </summary>
[SupportedOSPlatform("browser")]
public partial class JavaScriptModule
{
    public static async Task ImportModuleAsync() => await JSHost.ImportAsync("MyModule", "/js/JavaScriptModule.js");

    [JSImport("HelloBlazorSchool", "MyModule")]
    public static partial void HelloBlazorSchool();

    [JSImport("PredictableFunction", "MyModule")]
    public static partial string PredictableFunction();

    [JSImport("UnpredictableFunction", "MyModule")]
    public static partial string UnpredictableFunction();

    [JSImport("FunctionWithReturnedObject", "MyModule")]
    public static partial JSObject FunctionWithReturnedObject();

    [JSImport("FunctionWithAutoMarshallingParameters", "MyModule")]
    public static partial string AutoMarshallingFunctionWithPrimitiveParameters(string param1, int param2, bool param3);

    [JSImport("FunctionWithPrimitiveParameters", "MyModule")]
    public static partial string ManualMarshalToFunctionWithPrimitiveParameters([JSMarshalAs<JSType.String>] string param1, [JSMarshalAs<JSType.BigInt>] long param2, [JSMarshalAs<JSType.Date>] DateTime param3);

    [JSImport("FunctionWithMethodParameter", "MyModule")]
    public static partial string FunctionWithReferenceParameter([JSMarshalAs<JSType.Function<JSType.Number, JSType.Number, JSType.Number>>] Func<int, int, int> csharpMethod);

    [JSExport]
    public static void AutoMarshallingPrimitiveParametersToMethod(string param1, int param2, bool param3) => Console.WriteLine($"Received parameters at C#: {param1.GetType()}: {param1}, {param2.GetType()}: {param2}, {param3.GetType()}: {param3}");

    [JSExport]
    public static void ManualMarshalPrimitiveParametersToMethod([JSMarshalAs<JSType.String>] string param1, [JSMarshalAs<JSType.Number>] long param2, [JSMarshalAs<JSType.Date>] DateTime param3) => Console.WriteLine($"Received parameters at C#: {param1.GetType()}: {param1}, {param2.GetType()}: {param2}, {param3.GetType()}: {param3}");

    [JSExport]
    public static void MarshalFunctionToMethod([JSMarshalAs<JSType.Function>] Action param1) => param1.Invoke();
}