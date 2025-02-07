using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create videos and add them to the list
        Video video1 = new Video("Learning C#", "Maxwell John", 300);
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "I learned a lot from this. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Nice explanation of concepts."));
        videos.Add(video1);

        Video video2 = new Video("Understanding Variables", "Maxine Lucas", 450);
        video2.AddComment(new Comment("Divine", "This helped me understand variables better."));
        video2.AddComment(new Comment("Evelyn", "Excellent tutorial!"));
        video2.AddComment(new Comment("Franklin", "I appreciate the examples provided."));
        videos.Add(video2);

        Video video3 = new Video("Advanced C# Techniques", "Micheal Smith", 600);
        video3.AddComment(new Comment("Glory", "Very detailed and well explained."));
        video3.AddComment(new Comment("Hank", "I love the depth of this video."));
        video3.AddComment(new Comment("Ivana", "This is exactly what i needed!"));
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}