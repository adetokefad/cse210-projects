public class ReflectingActivity : Activity
{
     private List<string> _prompts = new List<string>
     {
         "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
         "Think of a time when you did something truly selfless."
     };

     private List<string> _questions = new List<string>
     {
         "Why was this experience meaningful to you?",
         "How did you feel when it was complete?",
         "What could you learn from this experience that applies to other situations?"
     };

     public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you ahve shown strength and resilience.") { }

     public void Run()
     {
          DisplayStartingMessage();
          var prompt = GetRandomprompt();
          Console.WriteLine(prompt);

          ShowCountDown(5); 
          DisplayQuestions();
          DisplayEndingMessage();
     }

     private string GetRandomprompt()
     {
          Random rand = new Random();
          return _prompts[rand.Next(_prompts.Count)];
     }

     private void DisplayQuestions()
     {
          Random rand = new Random();
          foreach (var question in _questions)
          { 
               Console.WriteLine(question);
               ShowSpinner(5);
          }
     }
}