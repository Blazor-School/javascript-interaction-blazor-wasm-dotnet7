export function RemoveBlazorDOM()
{
    document.getElementById("blazorschool").remove();
}

export function CallJSFunction(csharpObject)
{
    csharpObject.invokeMethodAsync("CallCSharpMethodAsync");
}