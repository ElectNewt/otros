namespace csharp10;
public class DateTimeOnly
{
    public void Ejemplo()
    {
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        TimeOnly time = TimeOnly.FromTimeSpan(TimeSpan.FromHours(13));
        
    }
}
