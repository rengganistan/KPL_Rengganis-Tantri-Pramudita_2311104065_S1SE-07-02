using modul6_2311104065;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Rengganis");

        string[] filmTitles = {
            "Inception", "Interstellar", "The Dark Knight", "Parasite",
            "Avengers: Endgame", "Forrest Gump", "The Shawshank Redemption",
            "Titanic", "Spirited Away", "The Matrix"
        };

        foreach (string title in filmTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo($"{title} oleh Rengganis");
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}