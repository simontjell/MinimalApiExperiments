public record Person(string Name);
public record Greeting(string Message, string? ValidationError = null);
public record Time(int Hours, int Minutes, int Seconds)
{
    public Time(TimeOnly timeOnly) : this(timeOnly.Hour, timeOnly.Minute, timeOnly.Second)
    {}
}
