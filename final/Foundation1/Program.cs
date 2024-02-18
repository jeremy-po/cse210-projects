using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("This is The Worst Car I've Ever Reviewed", "Auto Focus", 1233),
            new Video("I HELPED BUILD AN F1 CAR", "Mat Armstrong MK2", 892),
            new Video("Joao Gomes brace sinks Spurs! | Tottenham 1-2 Wolves match highlights", "Wolves", 149)
        };

        videos[0].AddComment(new Comment("User1", "fisker isn't particularly known for their quality. or their reputation. or anything really."));
        videos[0].AddComment(new Comment("User2", "Fisker sounds like Friskies cat food. I drive a Friskies Ocean"));
        videos[0].AddComment(new Comment("User3", "That tray in the center console is the quirkiest thing I've seen in a car made in the past 10 years"));

        videos[1].AddComment(new Comment("User4", "From Fixing a Audi TT to working on a F1 car which is the pinnacle of motor engineering is remarkable. Well done Mat"));
        videos[1].AddComment(new Comment("User5", "Best thing about Matt's channels is without a shadow of doubt, his relationship with his dad. Tony's an absolute role model for dad's the world over"));
        videos[1].AddComment(new Comment("User6", "You have to be kidding me... How much further can you go.... Well done mate"));

        videos[2].AddComment(new Comment("User7", "I am a South Korean fan. Tonight is Gomes. Wonderful cos we have got away game. Keep going."));
        videos[2].AddComment(new Comment("User8", "Great victory as a visitor against a good rival like Tottenham, these three points help us after the setback we had last weekend. Keep going and keep working guys."));
        videos[2].AddComment(new Comment("User9", "Pedro Neto is a world-class"));

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Commenter}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
