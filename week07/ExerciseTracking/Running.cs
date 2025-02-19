public class Running : Activity
{
     private double distance;

     public Running(DateTime date, int duration, double distance) : base(date, duration)
     {
          this.distance = distance;
     }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary().Replace("unit", "miles")}";
    }
}