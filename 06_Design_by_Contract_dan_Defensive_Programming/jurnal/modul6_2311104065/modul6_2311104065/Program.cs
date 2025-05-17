using modul6_2311104065;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Rengganis");

        string[] filmTitles = { "Inception", "Interstellar", "The Dark Knight", "Parasite", "Avengers: Endgame", "Forrest Gump", "The Shawshank Redemption", "Titanic", "Spirited Away", "The Matrix" };

        for (int i = 0; i < filmTitles.Length; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"{filmTitles[i]} oleh Rengganis");
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();

        // Menguji Precondition & Exception
        try
        {
            SayaTubeVideo invalidVideo = new SayaTubeVideo(""); // Ini akan menyebabkan exception
        }
        catch (Exception e)
        {
            Console.WriteLine("Precondition Test: " + e.Message);
        }

        try
        {
            SayaTubeVideo normalVideo = new SayaTubeVideo("Test Video");
            normalVideo.IncreasePlayCount(int.MaxValue); // Akan memicu overflow exception
        }
        catch (Exception e)
        {
            Console.WriteLine("Overflow Test: " + e.Message);
        }
    }
}