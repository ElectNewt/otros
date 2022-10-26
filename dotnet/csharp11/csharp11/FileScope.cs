namespace csharp11;

public class CualquerCasoDeuso
{
    public void Execute()
    {
        FileScope fileScope = new();
        fileScope.Execute();
    }
}

file class FileScope
{

    public void Execute()
    {
        Console.WriteLine("este metodo solo se puede llamar desde el mismo fichero");
    }
}
