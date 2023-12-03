using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string text, Reference reference)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
        var random = new Random();
        var wordsToHide = words.Where(w => !w.IsHidden).OrderBy(x => random.Next()).Take(count);
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AreAllWordsHidden() => words.All(w => w.IsHidden);

    public override string ToString()
    {
        return $"{reference.GetDisplayText()} {string.Join(" ", words.Select(w => w.GetDisplayText()))}";
    }

    public void ShowHint()
    {
        var hiddenWords = words.Where(w => w.IsHidden).ToList();
        if (hiddenWords.Any())
        {
            var random = new Random();
            var wordToReveal = hiddenWords[random.Next(hiddenWords.Count)];
            wordToReveal.Unhide();
        }
    }

    public void HideWordsDifficulty(int difficulty)
    {
        int count = difficulty switch
        {
            1 => 1, // Easy
            2 => 3, // Medium
            3 => 5, // Hard
            _ => 3, // Default to Medium
        };
        HideRandomWords(count);
    }
}