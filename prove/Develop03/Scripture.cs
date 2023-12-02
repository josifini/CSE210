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
}
