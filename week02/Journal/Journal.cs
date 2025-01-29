using System;
public class Journal
{
    private List<Entry> _entries;
    private static readonly string[] _prompts = new[]
    {
        "Who was the most interersting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the stronggest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string response)
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0].Trim();
                    string prompt = parts[1].Trim();
                    string response = parts[2].Trim();
                    Entry entry = new Entry(prompt, response) { Date = date };
                    _entries.Add(entry);
                }
            }
        }
    }
}