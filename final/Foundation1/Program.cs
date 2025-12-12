using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Cookie Baking 101" , "Cookie Monster" , 2346);
        video1.AddComment(new Comments("Ernie" , "The part where he ate half the dough before baking is the most relatable thing I've ever seen!"));
        video1.AddComment(new Comments("Elmo" , "This is the most chaotic baking tutorial ever."));
        video1.AddComment(new Comments("BigBird" , "It is just me, or did Cookie Monster say ever ingredient was optional except for chocolate chips?"));
        videos.Add(video1);

        Video video2 = new Video("Finding John" , "Jane Doe" , 1638);
        video2.AddComment(new Comments("Sophie" , "John disappearing behind the couch like a ninja was peak!"));
        video2.AddComment(new Comments("Sam Smarts" , "I can't believe you found John, he was hidding so well."));
        video2.AddComment(new Comments("Thomas Jets" , "That jump scare by John at the end was unexpected."));
        video2.AddComment(new Comments("Abby Smith" , "Why was this more intense than half the thriller movies I've watched?"));
        videos.Add(video2);

        Video video3 = new Video("Look At That Watch" , "Dr. Clock" , 1034);
        video3.AddComment(new Comments("Sarah Tyme" , "Dr. Clock explaining watch mechanics is smoother than the movement in a Swiss automatic."));
        video3.AddComment(new Comments("Olivar Gears" , "Dr. Clock saying ‘time is fragile’ right before dropping the watch nearly ended me."));
        video3.AddComment(new Comments("Austin Silver" , "Can we appreciate how clearly he breaks down complex watch parts? Even I understood it!"));
        video3.AddComment(new Comments("Jackie Black", "Thanks Dr. Clock, I can't wait to see more!"));
        videos.Add(video3);

        Video video4 = new Video("Sporting Stuff" , "Jeff Football" , 3153);
        video4.AddComment(new Comments("Tori White" , "This channel breaks down highlights better than the actual broadcasters. Loving the energy!"));
        video4.AddComment(new Comments("Josh Day" , "How does Sporting Stuff upload so fast? The game literally ended like 10 minutes ago."));
        video4.AddComment(new Comments("Ben Cox" , "Clean visuals, great stats, smooth commentary—this is becoming my go-to sports recap channel."));
        videos.Add(video4);

        Console.WriteLine("=== YouTube Video Tracker ===\n");

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideos());
            Console.WriteLine("Comments:");

            foreach (Comments comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayComments());
            }

            Console.WriteLine();
        }
    }
}