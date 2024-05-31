using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("The Facts Nearly Everyone Gets Wrong About Pluto", "Astrum", "1047");
        Video v2 = new Video("What Jumping Spiders Teach Us About Color", "Veritasium", "1957");
        Video v3 = new Video("This Is What a 'Second-Person' Video Game Would Look Like", "Nick Robinson", "956");

        Comment v1c1 = new Comment("Jubes83","If it's any consolation do the Pluto fans, it went from being the smallest planet to the king of the dwarf planets.");
        Comment v1c2 = new Comment("briancohen-doherty4392","A tour of the dwarf planets would be fun.");
        Comment v1c3 = new Comment("wangshuntian","That makes me feel even much more respect to the guy who found pluto.");

        Comment v2c1 = new Comment("tommyvictorbuch6960","If you have two green balls in your hand, you have Kermit's full attention.");
        Comment v2c2 = new Comment("tns6862","Fun Fact: Jumping Spiders are the only spiders allowed to live in my house. They're intellegent, you look at them and look back at you, expectedly. I wave them a 'carry on' and they go about their day.");
        Comment v2c3 = new Comment("MrPigpigbob","Its insane to see your production quality improve over the years. This is an actual documentary.");

        Comment v3c1 = new Comment("jaymiexosmo","Second person is when you're watching your big brother finish the hard level for you.");
        Comment v3c2 = new Comment("derdodel7978","Fourth person: your character reads a newspaper about the events of the game.");
        Comment v3c3 = new Comment("nekomancer350","Very interesting video. Wasn't expecting the 'second-person' perspective to translate in such a strange and unique way. Props to whoever came up with the idea for that mission.");
        Comment v3c4 = new Comment("megglezeee6090","It's crazy how well he can describe a simple video game clip like it's an ancient work of art.");

        v1.AddComment(v1c1);
        v1.AddComment(v1c2);
        v1.AddComment(v1c3);

        v2.AddComment(v2c1);
        v2.AddComment(v2c2);
        v2.AddComment(v2c3);

        v3.AddComment(v3c1);
        v3.AddComment(v3c2);
        v3.AddComment(v3c3);
        v3.AddComment(v3c4);

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach(Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }

    }
}