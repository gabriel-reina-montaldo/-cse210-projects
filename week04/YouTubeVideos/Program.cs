using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("What makes this song great? The Beatles", "Rick Beato", 560);

        Comment comment1 = new Comment("John", "This song is amazing!");
        Comment comment2 = new Comment("Sarah", "I love The Beatles.");
        Comment comment3 = new Comment("Mike", "I hope you get to interview Paul McCartney some day.");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Why Do We Dream?", "Kurzgesagt", 620);

        Comment comment4 = new Comment("Lucas", "This topic is really interesting.");
        Comment comment5 = new Comment("Sofia", "I never knew this about dreams.");
        Comment comment6 = new Comment("Chris", "Another great explanation from this channel.");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("The History of Cinema", "The Cinema Cartography", 720);

        Comment comment7 = new Comment("Michael", "I really enjoyed learning about the history of movies.");
        Comment comment8 = new Comment("Sarah", "The video explains the evolution of cinema very well.");
        Comment comment9 = new Comment("David", "I learned many things I did not know before.");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}