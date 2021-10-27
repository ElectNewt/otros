
namespace csharp10;
internal class PropertyPatterns
{
    public record Subtipo(int Edad);
    public record Persona(string Nombre, Subtipo subtipo);

    public void Ejemplo()
    {
        Persona persona = new Persona("Ivan", new(29));

        string resultado = ExpressionCsharp10(persona);
    }

    private static string ExpressionCsharp10(Persona persona) =>
        persona switch
        {

            { subtipo.Edad: >= 18 } => "es mayor de edad",
            { subtipo.Edad: < 18 } => "es menor de edad",
            _ => throw new NotSupportedException()
        };


    //Este ejemplo es en c#9, es muy verbose
    private static string ExpressionCsharp9(Persona persona) =>
        persona switch
        {

            { subtipo: { Edad: >= 18 } } => "es mayor de edad",
            { subtipo: { Edad: < 18 } } => "es menor de edad",
            _ => throw new NotSupportedException()
        };
}




