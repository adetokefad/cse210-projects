public class Activity
{
     protected string _name;
     protected string _description;
     protected int _duration;

     public Activity(string name, string description)
     {
          _name = name;
          _description = description;
     }

     public void SetDuration()
     {
          Console.Write("Enter the duration of the activity in seconds: ");
          _duration = int.Parse(Console.ReadLine());
     }

     public void DisplayStartingMessage()
     {
          Console.WriteLine($"Starting {_name}...");
          Console.WriteLine(_description);
          SetDuration();
          Console.WriteLine("Prepare to begin...");
          ShowSpinner(3);
     }

     public void DisplayEndingMessage()
     {
          Console.WriteLine("Good job!");
          ShowSpinner(2);
          Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
     }

     protected void ShowSpinner(int seconds)
     {
          for (int i = 0; i < seconds; i++)
          {
               Console.Write(".");
               Thread.Sleep(1000);
          }
          Console.WriteLine();
     }

     protected void ShowCountDown(int seconds)
     {
          for (int i = seconds; i > 0; i--)
          {
               Console.WriteLine(i);
               Thread.Sleep(1000);
          }
     }
}