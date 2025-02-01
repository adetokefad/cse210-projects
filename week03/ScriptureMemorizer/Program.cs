using System;
using System.Collections.Generic;
class Program
/*
In addition to the core requirements, the program includes:
- A library of scriptures that allows for random selection, enhancing user experience.
- The ability to hide words randomly, ensuring that the game remains engaging and challenging.
- Clear console management to improve readability and user interaction.
- Encapsulation principles are followed by using private fields and public methods to manage access to class data.
- The program is structured to allow easy expansion, such as adding more scriptures or modifying the hiding logic.
*/
{
    static void Main(string[] args)
    {
        // Create a Library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John 3:16"), "For God so loved the world that he gave his only begotten son, that whosoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs 3:5-6"), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians 4:13"), "I can do all this through him who gives me strength."),
            new Scripture(new Reference("Romans 8:28"), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Isaiah 40:31"), "But those who hope in the Lord will renew their strength. They will soar on wings like eagles; they will run and not grow weary; they will walk and not be faint.")
        };
        Random random = new Random();
        bool continueGame = true;

        while (continueGame)
        {
            // Select a random scripture
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
            selectedScripture.Display();

 Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                continueGame = false;
            }
            else
            {
                Console.Clear();
                if (selectedScripture.HideRandomWord())
                {
                    selectedScripture.Display();
                }
                else
                {
                    Console.WriteLine("All words are now hidden.");
                    continueGame = false;
                }  
            }
        }
    }
}  