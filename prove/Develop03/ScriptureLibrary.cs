using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();

    public void LoadFromFile(string GetRandomScripture)
    {
        var lines = File.ReadAllLines(GetRandomScripture);
        foreach (var line in lines)
        {
            var parts = line.Split(';');
            if (parts.Length == 4)
            {
                var reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                scriptures.Add(new Scripture(parts[3], reference));
            }
        }
    }

    public Scripture GetRandomScripture()
    {
        
        {
            if (scriptures.Count == 0)
            {
                throw new InvalidOperationException("No scriptures loaded.");
            }
            var random = new Random();
            return scriptures[random.Next(scriptures.Count)];
        }
    }
}