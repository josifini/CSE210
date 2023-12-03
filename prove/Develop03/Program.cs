using System;

class Program
{
    static void Main()
    {
        var scriptureLibrary = new ScriptureLibrary();
        scriptureLibrary.LoadFromFile("/Users/josifinimotukiliu/Desktop/CSE210/prove/Develop03/scriptures.txt");

        Scripture scripture;

        try
        {
            scripture = scriptureLibrary.GetRandomScripture();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            return; // Exit the program, or you could provide logic to handle the exception.
        }

        int difficulty = 2; // Default difficulty level

        while (!scripture.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            Console.WriteLine("Press Enter to hide words, type 'hint' for a hint, 'difficulty' to change difficulty, or 'quit' to exit.");

            var input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;
            if (input?.ToLower() == "hint")
            {
                scripture.ShowHint();
                continue;
            }
            if (input?.ToLower() == "difficulty")
            {
                Console.WriteLine("Select Difficulty (1-Easy, 2-Medium, 3-Hard):");
                if (int.TryParse(Console.ReadLine(), out int newDifficulty))
                {
                    difficulty = newDifficulty;
                }
                continue;
            }

            scripture.HideWordsDifficulty(difficulty);
        }
    }
}
