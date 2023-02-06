function HelloBlazorSchool()
{
    alert(`Hello Blazor School from Global standard JS.`);
}

async function CallAutoMarshalingPrimitiveParameterStaticCSharpMethodAsync()
{
    let rootAssembly = await globalThis.getDotnetRuntime(0).getAssemblyExports("JavaScriptInteraction.dll");
    rootAssembly.JavaScriptInteraction.InteropServicesModules.JavaScriptModule.AutoMarshallingPrimitiveParametersToMethod("Blazor School", 5, true);
}

async function CallManualMarshalPrimitiveParameterStaticCSharpMethodAsync()
{
    let rootAssembly = await globalThis.getDotnetRuntime(0).getAssemblyExports("JavaScriptInteraction.dll");
    rootAssembly.JavaScriptInteraction.InteropServicesModules.JavaScriptModule.ManualMarshalPrimitiveParametersToMethod("Blazor School", 5, new Date());
}

async function MarshalFunctionToStaticCSharpMethodAsync()
{
    let rootAssembly = await globalThis.getDotnetRuntime(0).getAssemblyExports("JavaScriptInteraction.dll");
    rootAssembly.JavaScriptInteraction.InteropServicesModules.JavaScriptModule.MarshalFunctionToMethod(HelloBlazorSchool);
}