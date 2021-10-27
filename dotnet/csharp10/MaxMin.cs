namespace csharp10;
internal class MaxMin
{
    public void Ejemplo()
    {
        List<MaxMinEjemplo> ejemploLista = new()
        {
            new(3, "prioridad 3"),
            new(2, "prioridad 2"),
            new(10, "prioridad 10"),
            new(8, "prioridad 8")
        };

        int max = ejemploLista.Max(x=>x.Prioridad); //Devuleve 10 (como entero)
        MaxMinEjemplo? maxBy = ejemploLista.MaxBy(x => x.Prioridad);//Devuelve el objeto con prioridad 10
    }

}

public record MaxMinEjemplo(int Prioridad, string Valor);

