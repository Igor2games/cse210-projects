using System;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video("A Brand new Horror Game", "Markiplier", 1200);
        Comment comment11 = new Comment("Mikaela", "Meow");
        Comment comment12 = new Comment("Pelucia", "WoWoW");
        Comment comment13 = new Comment("XxDemon_SlayerxX", "I cant believe people are scared of this game, it so cheezy");
        video1.AddComment(comment11);
        video1.AddComment(comment12);
        video1.AddComment(comment13);

        // Video 2
        Video video2 = new Video("An introduction to C#", "TechMaster", 5000);
        Comment comment21 = new Comment("Python Enjoyer", "Why waster time with such an inferior programming lanuage, you savages!");
        Comment comment22 = new Comment("Alicia", "A great tuotial for begginers, subscribed!!!");
        Comment comment23 = new Comment("Melon", "im still at a complete loss, what the heck is an interger?");
        video2.AddComment(comment21);
        video2.AddComment(comment22);
        video2.AddComment(comment23);

        // Video 3
        Video video3 = new Video("Hacking tutorial, how to get infinite V-bucks!!!", "TechMaster", 600);
        Comment comment31 = new Comment("Truth_Seeker", "Guys dont waste time on this video this is a scam!");
        Comment comment32 = new Comment("NotAHacker", "Dont liste to that loser above, it worked fine for me!");
        Comment comment33 = new Comment("Truth_Seeker", "Please, this is no joke, thats some hardcore malware");
        Comment comment34 = new Comment("XObliviou876X", "i tried and it just stole all my data, GG guys");
        video3.AddComment(comment31);
        video3.AddComment(comment32);
        video3.AddComment(comment33);
        video3.AddComment(comment34);

        var videos = new List<Video> {video1, video2, video3};

        foreach (var vid in videos)
        {
            Console.WriteLine($"Title: {vid.GetTitle()}\nAuthor: {vid.GetAuthor()}\nLenght: {vid.GetlenghtSeconds()} Seconds\n");
            Console.WriteLine($"{vid.CountComments()} Comments");

            foreach (Comment commnet in vid.GetComments())
            {
                Console.WriteLine($"Name: {commnet.GetName()} \n{commnet.GetText()}\n");
            }
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}