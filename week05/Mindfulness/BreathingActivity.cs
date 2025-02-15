public class BreathingActivity : Activity
{
     public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ") { }

     public void Run()
     {
          DisplayStartingMessage();
          for (int i = 0; i < _duration; i += 4)
          {
               Console.WriteLine("Breathe in...");
               ShowCountDown(4);
               Console.WriteLine("Breathe out...");
               ShowCountDown(4);
          }
          DisplayEndingMessage();
     }
}