namespace csharp10;
internal class TakeEjemplo
{
    public void Ejemplo()
    {
        List<int> listInts = Enumerable.Range(0, 1000).ToList();//lista de 1000 elementos
        var resultCsharp9 = listInts.Skip(10).Take(15);
        var resultCsharp10 = listInts.Take(10..25);
    }
}



