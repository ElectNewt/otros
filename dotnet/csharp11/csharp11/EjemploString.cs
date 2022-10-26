namespace csharp11;

internal class EjemploString
{

    public void EjemploStringLieral()
    {
        string stringLiteral = """
            esto es 
            un ejemplo de string literal:
                    con diferentes niveles de interpolacion
        """;

        string valor1 = "test";
        string stringLiteralPura = $$$"""
            esto es 
        un ejemplo de string literal pura:
        donde podemos poner variables: {{{valor1}}}
        """;
    }

    public void EjemploStringLiteralUtf8()
    {
        byte[] resultado = "Esto es una frase de ejemplo"u8.ToArray();
    }

    public void EjemploInterpolation()
    {
        int variable = 1;
        string example = $"El valor de ejemplo es: {variable switch
        {
            > 1 => "el valor es 1",
            _ => "valor no registrado",
        }}";
    }
}
