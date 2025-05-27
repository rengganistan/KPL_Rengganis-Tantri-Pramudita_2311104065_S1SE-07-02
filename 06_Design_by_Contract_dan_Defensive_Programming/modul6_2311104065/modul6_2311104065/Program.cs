
using System;

public class Program
{
    public static void Main()
    {
        SayaTubeUser user = null;

        // Uji Precondition username
        try
        {
            user = new SayaTubeUser("Rengganis");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception username: " + e.Message);
        }

        string[] titles = {
            "Review Film Beranak Dalam Kubur oleh Rengganis",
            "Review Film Inception oleh Rengganis",
            "Review Film The Dark Knight oleh Rengganis",
            "Review Film Parasite oleh Rengganis",
            "Review Film Joker oleh Rengganis",
            "Review Film Dune oleh Rengganis",
            "Review Film Tenet oleh Rengganis",
            "Review Film Whiplash oleh Rengganis",
            "Review Film La La Land oleh Rengganis",
            "Review Film The Shawn the Sheep oleh Rengganis"
        };

        if (user != null)
        {
            foreach (var title in titles)
            {
                try
                {
                    SayaTubeVideo video = new SayaTubeVideo(title);
                    video.IncreasePlayCount(1000000); // Valid play count
                    user.AddVideo(video);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception saat tambah video: " + e.Message);
                }
            }

            user.PrintAllVideoPlaycount(); // Postcondition: hanya print max 8 video
            Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());
        }

        // Uji Overflow
        try
        {
            SayaTubeVideo videoOverflow = new SayaTubeVideo("Uji Overflow oleh Seng");
            for (int i = 0; i < 1000; i++) // Mempercepat overflow
            {
                videoOverflow.IncreasePlayCount(25000000); // Maksimal per call
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception saat overflow: " + e.Message);
        }
    }
}
