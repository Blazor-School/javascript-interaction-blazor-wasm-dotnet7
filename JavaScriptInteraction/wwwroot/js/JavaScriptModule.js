export function HelloBlazorSchool()
{
    alert("Hello Blazor School!");
}

export function PredictableFunction()
{
    return "Hello Blazor School!";
}

export function UnpredictableFunction()
{
    let randomNum = Math.random() * 10;

    if (randomNum < 3)
    {
        return "Blazor School";
    }

    if (3 < randomNum && randomNum < 6)
    {
        return 10;
    }

    return;
}

export function FunctionWithReturnedObject()
{
    let exampleObject = {
        exampleString: "Blazor School",
        exampleInt: 9000,
        exampleDate: new Date()
    };

    return exampleObject;
}

export function FunctionWithPrimitiveParameters(stringData, numberData, dateTimeData)
{
    alert(`Received: string ${stringData}, number ${numberData}, date time ${dateTimeData}`);
}

export function FunctionWithReferenceParameter(csharpObjectReference)
{
    alert(`Received object not null? - ${csharpObjectReference != null}`);
}

export function FunctionWithObjectParameter(csharpObject)
{
    alert(`Received object data: string ${csharpObject.exampleString}, number ${csharpObject.exampleInt}, date time ${csharpObject.exampleDate}`);
}

export function CallSynchronousCSharpMethod(csharpObject)
{
    csharpObject.invokeMethodAsync("ExampleVoidMethod");
}

export async function CallAsynchronousCSharpMethod(csharpObject)
{
    await csharpObject.invokeMethodAsync("ExampleVoidMethodAsync");
}

export function CallPrimitiveParameterizedCSharpMethod(csharpObject)
{
    csharpObject.invokeMethodAsync("MethodWithPrimitiveParameters", "Blazor School", 100, new Date());
}

export function CallReferenceParameterizedCSharpMethod(csharpObject)
{
    let passingObject = {
        exampleString: "Blazor School",
        exampleInt: 9000,
        exampleDate: new Date()
    };

    csharpObject.invokeMethodAsync("MethodWithReferenceParameters", passingObject);
}

export function CallLocalComponentMethod(componentInstance)
{
    componentInstance.invokeMethodAsync("LocalMethod");
}

export async function CallPrimitiveDataReturnMethod(csharpObject)
{
    let result = await csharpObject.invokeMethodAsync("ExamplePrimitiveReturnMethod");
    alert(`The result is ${result}`);
}

export async function CallReferenceDataReturnMethod(csharpObject)
{
    let result = await csharpObject.invokeMethodAsync("ExampleReferenceReturnMethod");
    alert(`Received object data: string ${result.exampleString}, number ${result.exampleInt}, date time ${result.exampleDate}`)
}

export function FunctionWithAutoMarshallingParameters(stringData, numberData, booleanData)
{
    alert(`Received object data: string ${stringData}, number ${numberData}, boolean ${booleanData}`);
}

export function FunctionWithMethodParameter(csharpMethod)
{
    alert(`Using C# method to calculate 1 + 2. Result: ${csharpMethod(1, 2)}`);
}

export async function CallToupleDataReturnMethod(csharpObject)
{
    let result = await csharpObject.invokeMethodAsync("ExampleToupleReturnMethod");
    console.info(result);
}