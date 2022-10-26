namespace csharp10;
internal class ColaPrioridad
{
    public void Ejemplo()
    {
        PriorityQueue<string, int> colaPrioridad = new PriorityQueue<string, int>();

        colaPrioridad.Enqueue("Opel", 2);
        colaPrioridad.Enqueue("Audi", 1);
        colaPrioridad.Enqueue("BMW", 3);
        
    } 

}

