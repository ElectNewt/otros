namespace csharp10;
public class ConstInterpolatedStrings
{
    public const string Nombre = "Netmentor";
    public const string Saludo = $"Hola {Nombre}!";

    //así se hacia en c# 9
    public static readonly string SaludoCsharp9 =  $"Hola {Nombre}!";
}


