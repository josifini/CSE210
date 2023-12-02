using System;

class Program
{
    static void Main()
    {
        var scriptureText = "For God so loved the world, that He gave His only Son";
        var scriptureReference = new Reference("John", 3, 16);
        var scripture = new Scripture(scriptureText, scriptureReference);

        while (!scripture.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.ToString());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

            scripture.HideRandomWords();
        }
    }
}