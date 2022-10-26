namespace csharp11;

public class GenericAttribute<T> : Attribute
{

}

internal class AtributosGenericos
{
    [GenericAttribute<string>]
    public void Example() { }
}

internal class AtributosGenericosEj2<T>
{
    //esto no compila
    //[GenericAttribute<T>]
    public void Example() { }
}
