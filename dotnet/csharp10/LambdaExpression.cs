namespace csharp10;
internal class LambdaExpression
{

    public void Ejemplo()
    {
        Func<string> lambdaExpression = () => "hola Netmentor.";
       

        Func<string?> conRetorno = string? () => "hola Netmentor!";
    }
}

