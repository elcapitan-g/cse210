using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Video video1 = new Video("Spearfishing for dummies", "Underwater Bryce", 300);
        video1.Comments.Add(new Comment("Gerald", "You da realz dummy"));
        video1.Comments.Add(new Comment("Kea", "Mahalo nui!"));
        video1.Comments.Add(new Comment("Kaohi", "Not useful"));

        Video video2 = new Video("How to cook menpachi", "Po'o Fishing", 500);
        video2.Comments.Add(new Comment("Kawika", "Pono bro"));
        video1.Comments.Add(new Comment("Mahina", "A weh!"));
        video1.Comments.Add(new Comment("Nicole", "Imppressive"));

        Video video3 = new Video("Shark Attack 2024", "Mike Johnson", 600);
        video3.Comments.Add(new Comment("Alexandria", "So scary this one!"));
        video3.Comments.Add(new Comment("Lani", "Not swimming for one whole month now!"));
        video3.Comments.Add(new Comment("Bubba", "Fake!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}