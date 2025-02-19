public abstract class Activity
{
     private DateTime date;
     protected int duration;

     protected Activity(DateTime date, int duration)
     {
          this.date = date;
          this.duration = duration;
     }

     public abstract double GetDistance();
     public abstract double GetSpeed();
     public abstract double GetPace();

     public virtual string GetSummary()
     {
          return $"{date:dd MMM yyyy} {GetType().Name} ({duration} min) - Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2} min per unit";
     }
}