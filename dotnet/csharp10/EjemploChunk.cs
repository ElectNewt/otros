namespace csharp10;
internal class EjemploChunk
{
    public void Ejemplo()
    {

        IEnumerable<int> listInts = Enumerable.Range(0, 1000);//lista de 1000 elementos

        int chunkSize = 50;
        foreach (var chunk in listInts.Chunk(chunkSize)) //devuelve una lista con el tamano indicado. 
        {
            //Llamadas paralelas
            Parallel.ForEach(chunk, (item) =>
            {
                Console.WriteLine($"Simulamos get con id {item}");
            });
        }
    }

}

