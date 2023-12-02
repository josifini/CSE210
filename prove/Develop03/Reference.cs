public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse;

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
    }

    // Constructor for verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
        : this(book, chapter, startVerse)
    {
        this.endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return endVerse != null 
            ? $"{book} {chapter}:{startVerse}-{endVerse}" 
            : $"{book} {chapter}:{startVerse}";
    }
}
