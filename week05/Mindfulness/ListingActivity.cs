public class ListingActivity : Activity
{
     private int _count;
     private List<string> _prompts = new List<string>
     {
          "Who are people that you appreciate?",
          "What are personal strengths of yours?",
          "Who are people that you have helped this week?",
          "When have you felt the Holy Ghost this month?",
          "Who are some of your personal heroes?",
     };

     public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as many things as you can in a certain area.") { }

     public void Run()
     {
          DisplayStartingMessage();
          var prompt = GetRandomPrompt();
          Console.WriteLine(prompt);
          ShowCountDown(5);

          List<string> userInput = GetListFromUser();
          Console.WriteLine($"You Listed {userInput.Count} items.");
          DisplayEndingMessage();
     }

     private string GetRandomPrompt()
     {
          Random rand = new Random();
          return _prompts[rand.Next(_prompts.Count)];
     }

     private List<string> GetListFromUser()
     {
          List<string> items = new List<string>();
          Console.WriteLine("Start listing now (type 'done' to finish):");

          while (true)
          {
               string input = Console.ReadLine();
               if (input.ToLower() == "done") break;
               items.Add(input);
          }

          return items;
     }
}