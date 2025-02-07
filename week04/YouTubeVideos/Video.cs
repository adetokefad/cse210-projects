using System;

public class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int LengthInSeconds { get; private set;}
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Comments for '{Title}':");
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }

    public override string ToString()
    { 
        return $"Title: {Title}, Author: {Author}, Length : {LengthInSeconds} seconds";
    }
}