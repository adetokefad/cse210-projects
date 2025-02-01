public class Reference
{
    public string Verse { get; private set; }

    public Reference(string verse)
    {
        Verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Verse = $"{book} {chapter}:{startVerse}-{endVerse}";
    }

    public override string ToString()
    {
        return Verse;
    }
}