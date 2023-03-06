using System;
class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {
        string newDate = DateTime.Now.ToShortDateString();
        PromptGenerator promptGenerator = new  PromptGenerator();
        string newPrompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(newPrompt);
        string newResponse = Console.ReadLine();
        Entry newEntry = new Entry(newDate,newPrompt,newResponse );
        entries.Add(newEntry);
    }
    
    public void SaveToCSV()
    {
        Console.Write("Please enter the file name?: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.GetEntryAsCSV());
            }
        }

    }

    public void LoadFromCSV()
    {
        Console.Write("Please enter the file name?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry newEntry = new Entry(parts[0],parts[1],parts[2]);
            entries.Add(newEntry);
        }
    }

}