

namespace csharp10;
internal class EjemploRecords
{
    public record Persona(string Nombre, int Edad);
    

    public void Ejemplo()
    {
        Persona persona = new("Ivan", 29);
        Console.WriteLine($"El nombre es: {persona.Nombre}");
    }

    public record struct Notas(int Matematicas, int Ingles);

    public record PersonaString(string Nombre, int Edad)
    {
        public override string ToString()
        {
            return $"El nombre es: {Nombre} y su edad es: {Edad}";
        }
    }

    public void Ejemplo2()
    {
        PersonaString persona = new("Ivan", 28);
        Console.WriteLine(persona);
    }

    public record PersonaStringSealed(string Nombre, int Edad)
    {
        public override string ToString()
        {
            return $"El nombre es: {Nombre} y su edad es: {Edad}";
        }
    }

    public record Alumno : PersonaStringSealed
    {
        private Notas Notas;
        public Alumno(string nombre, int edad, Notas notas) : base(nombre, edad)
        {
            Notas = notas;
        }

        //da un error y no deja compilar
        public override string ToString()
        {
            return $"El nombre es: {Nombre} " +
                $"y su nota en matematicas es {Notas.Matematicas}";
        }
    }
}
