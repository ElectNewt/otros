namespace csharp10;
internal class LambdaExpression
{

    public void Ejemplo()
    {
        Func<string> lambdaExpression = () => "hola Netmentor.";
        var func = () => "hola Netmentor."; //En C#9 no deja compilar.

        Func<string?> conRetorno = string? () => "hola Netmentor!";
    }
}

