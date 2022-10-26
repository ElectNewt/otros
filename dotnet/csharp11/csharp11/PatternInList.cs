namespace csharp11;
internal class PatternInList
{
    public void Example()
    {
        int[] ejemploArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        bool result = ejemploArray is [1, 2, 3];

        //Otro ejemplo
        var resultado = ejemploArray switch
        {
            [1, .., 7] => 1,
            [1, 2, 3] => 1,
            [2, 3] => 2,
            _ => throw new NotImplementedException(),
        };

    }
}
