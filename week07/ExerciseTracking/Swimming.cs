public class Swimming : Activity
{
    private int Laps;

    public Swimming(DateTime date, int duration, int Laps) : base(date, duration)
    {
     this.Laps = Laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary().Replace("unit", "km")}";
    }
}