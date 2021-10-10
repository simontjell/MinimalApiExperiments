public interface ITimeEndpoint
{
    Time GetTime();
}

public class TimeEndpoint : ITimeEndpoint
{
    private IDateTimeProvider _dateTimeProvider;

    public TimeEndpoint(IDateTimeProvider dateTimeProvider)
        => (_dateTimeProvider) = (dateTimeProvider);

    public Time GetTime() => new Time(TimeOnly.FromDateTime(_dateTimeProvider.Now));
}