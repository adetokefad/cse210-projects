using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // List of return detail and Representative Strings
        List<string> strings = new();
        List<string> detailRep = new();

        // Loading the Quest Goal
        Console.WriteLine("Loading....");
        Console.WriteLine("Please be Patient");
        for (int i = 5; i > 0; i--){
            Console.Write("...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        // Keep track of score
        int score = 0;
        Console.WriteLine($"Good To Go..");
        
            
        Console.WriteLine("Welcome to:");
        
        string[] menuList = { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "RecordEvent", "Quit"};
        string nothing = "";
        int notEqualTo = 0;
        // While loop 
        while (notEqualTo != 6){
            Console.WriteLine("Quest and Task Completion Diary");
            Console.WriteLine("");
            Console.WriteLine($"You have {score} Point");
            Console.WriteLine("Menu Options:");
            // Displaying The list of Menu
            for (int i = 0; i < menuList.Length; i++)
            {
            nothing = menuList[i];
            Console.WriteLine($"{i + 1} - {nothing}");
            } 
            Console.Write("Select a Number from the menu to start to execute the Activity -> ");
            string enter = Console.ReadLine();
            notEqualTo = int.Parse(enter);
            Console.Clear();

            if (notEqualTo == 1){

                int listgoals = 0;
                while (listgoals != 4){
                    string[] typeOfGoals = { "Simple Goals", "Eternal Goals", "Checklist Goal", "To Quit"};
                    Console.WriteLine("---- Types Of Goal ----");

                    for (int i = 0; i < typeOfGoals.Length; i++)
                        {
                        nothing = typeOfGoals[i];
                        Console.WriteLine($"{i + 1} - {nothing}");
                        }
                    Console.Write("Press a number from the menu list to pick a type of Goal >> ");
                    enter = Console.ReadLine();
                    listgoals = int.Parse(enter);
                    if (listgoals == 1){
                        Console.Clear();
                        Console.Write("Enter a goal: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Describe: Where or What or How you want to do it!");
                        string describe = Console.ReadLine();
                        Console.Write("Enter point for completing this: ");
                        string point = Console.ReadLine();
                        int number = int.Parse(point);

                        SimpleGoal keepSimple = new(name, describe, number);
                        string keep = keepSimple.GetDetailsString();
                        string keep1 = keepSimple.GetStringRepresentation();
                        // Adding to lists
                        strings.Add(keep);
                        detailRep.Add(keep1);
                        // Adding to TrackPoint
                        
                        Console.WriteLine("Loading....");
                        Console.WriteLine("Please be Patient");
                        // keepSimple.SetDetailsList(keep);
                        keepSimple.Loading();
                    
                        Console.Clear();
                    }
                    else if(listgoals == 2){
                        Console.Clear();
                        Console.Write("Enter a goal: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Describe: Where or What or How you want to do it!");
                        string describe = Console.ReadLine();
                        Console.Write("Enter point for completing this: ");
                        string point = Console.ReadLine();
                        int number = int.Parse(point);

                        EternalGoal eternalGoal = new(name, describe, number);
                        string keep = eternalGoal.GetDetailsString();
                        string keep1 = eternalGoal.GetStringRepresentation();
                        strings.Add(keep);
                        detailRep.Add(keep1);
                        Console.WriteLine("Loading....");
                        Console.WriteLine("Please be Patient");
                        eternalGoal.Loading();
                    
                        Console.Clear();
                    }
                    else if (listgoals ==3){
                        Console.Clear();
                        Console.Write("Enter a goal: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Describe: Where or What or How you want to do it!");
                        string describe = Console.ReadLine();
                        Console.Write("Enter point for completing this: ");
                        string point = Console.ReadLine();
                        int number = int.Parse(point);
                        Console.Write("Enter a target numner: ");
                        point = Console.ReadLine();
                        int number1 = int.Parse(point);
                        Console.Write("Enter bonus point for completion");
                        point = Console.ReadLine();
                        int number2 = int.Parse(point);



                        CheckListGoal keepSimple = new(number1, number2, name, describe, number);
                        string keep = keepSimple.GetDetailsString();
                        strings.Add(keep);
                        Console.WriteLine("Loading....");
                        Console.WriteLine("Please be Patient");
                        keepSimple.Loading();
                    
                        Console.Clear();
                    }
                }
                
            }
            else if (notEqualTo == 2){
                for (int i = 0; i < strings.Count; i++)
                {
                    nothing = strings[i];
                    Console.WriteLine($"{i + 1}. {nothing}");
                } 
            }
            else if (notEqualTo == 3){
                GoalMangerMenu goalMenu = new();
                Console.WriteLine("Enter name of file path in .txt or csv");
                string filePath = Console.ReadLine();
                goalMenu.SaveGoals(detailRep, filePath);
            }

            else if (notEqualTo == 4){
                 Console.WriteLine("Enter the file path to load goals:");
                string filePath = Console.ReadLine();
                GoalMangerMenu goalLoader = new GoalMangerMenu();
                List<(string, string)> loadGoals = goalLoader.LoadGoal(filePath);
                foreach (var goal in loadGoals)
                {

                    Console.WriteLine($"Short Name: {goal.Item1}, Description: {goal.Item2}");
                    strings.Add($"{goal.Item1}, {goal.Item2}");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (notEqualTo == 5)
            {
                GoalMangerMenu goalMangerMenu = new();
                goalMangerMenu.RecordEvent(strings);
                
            }

        }
    }
}