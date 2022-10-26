namespace csharp11;

public ref struct EjemploRef
{

    public ref int valor;
    public int Getvalor()
    {
        if (System.Runtime.CompilerServices.Unsafe.IsNullRef(ref valor))
        {
            throw new InvalidOperationException("El valor no ha sido inizializdo");
        }

        return valor;
    }
}
