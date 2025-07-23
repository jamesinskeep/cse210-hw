using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // create first video
        Video video1 = new Video("I am the Ultimate Cucaracha on the Risk Meta Settings!", "Pete", 2935);
        // create second video
        Video video2 = new Video("This Final Trick Was Straight-Up Genius", "Kylted", 4942);
        // create third video
        Video video3 = new Video("North America For Life! on Fixed Friday", "The Kill Pete Strategy", 2685);
        // create fourth video
        Video video4 = new Video("The GREATEST One-Point Noob Corner of All-Time!", "vampirechicken", 1129);

        // add comments to the first video
        video1.AddComment(new Comment("21:48 - Red is snowballing, says Pete, with 3 caps and 6 bonuses", "Alexand3ry"));
        video1.AddComment(new Comment("Don't do it, that would be dumb! He did it, said the narrator.", "zekelor"));
        video1.AddComment(new Comment("it’s a shame someone cool like them had to go up against the Pete cucaracha", "@BillyShears230"));
        video1.AddComment(new Comment("Day up to Pete of oil asking 193 up", "@taylorchristensen-sn4bp"));
        // add comments to the second video
        video2.AddComment(new Comment("another great kylted video for my birthday", "@Chickennuggeteater9001"));
        video2.AddComment(new Comment("This was some absolute donkey Risk and I'm here for it", "@tari5981"));
        video2.AddComment(new Comment("The fact he played almost an hour only thinking about 5 caps made me laugh so hard at 57:13.", "@Primarch359"));
        // add comments to the third video
        video3.AddComment(new Comment("Happy Bday Pete you look excessively good for 41, shame on ya", "@Risky_moverino"));
        video3.AddComment(new Comment("18:29 , could blue have killed black here, thus taking Australia and 5 cards? ", "@ifell2"));
        video3.AddComment(new Comment("I love how Pete is so good at Risk that he can win with a 1v2 disadvantage", "@TheRealRiskyPete"));
        video3.AddComment(new Comment("Love watching your fixed friday videos! Keep making more like these.", "@akshatjain4283"));
        // add comments to the fourth video
        video4.AddComment(new Comment("What an epic position", "@Kylted"));
        video4.AddComment(new Comment("Only takes 4 min to realize red is blocked behind you.  Truly a GM big brain.", "@AllthingsRocco"));
        video4.AddComment(new Comment("Alas lunar mining monday, you were my favorite. That being said I'm just happy for the video, thank you.", "@justinianian"));
        video4.AddComment(new Comment("Too bad the other player weren't better. Seeing a good fight from that hold would have been fun to watch", "@Jordan-pf9ws"));


        // create a video list
        Video[] videos = new Video[] { video1, video2, video3, video4 };
        // print the video list
        Console.Clear();
        foreach (Video video in videos)
        {
            video.PrintVideo();
            foreach (Comment comment in video.Comments)
            {
                comment.PrintComment();
            }
        }
    }

}