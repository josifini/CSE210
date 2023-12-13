using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 240),
            // ... Add more videos as needed
        };

        // Adding comments to the first video
        videos[0].AddComment(new Comment("User1", "Interesting video!"));
        videos[0].AddComment(new Comment("User2", "Thanks for the information."));
        // ... Add more comments to videos[0]

        // Adding comments to the second video
        videos[1].AddComment(new Comment("User3", "Great content!"));
        videos[1].AddComment(new Comment("User4", "Very helpful."));
        // ... Add more comments to videos[1]

        // Displaying video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.NumberOfComments()}):");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
