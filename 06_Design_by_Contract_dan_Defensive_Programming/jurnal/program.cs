using modul6_2311104065;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Rengganis");

        List<string> videoTitles = new List<string>
        {
            "Review Film Inception oleh Rengganis",
            "Review Film Interstellar oleh Rengganis",
            "Review Film The Dark Knight oleh Rengganis",
            "Review Film Parasite oleh Rengganis",
            "Review Film The Godfather oleh Rengganis",
            "Review Film Fight Club oleh Rengganis",
            "Review Film The Matrix oleh Rengganis",
            "Review Film Joker oleh Rengganis",
            "Review Film Pulp Fiction oleh Rengganis",
            "Review Film Forrest Gump oleh Rengganis"
        };

        foreach (var title in videoTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}
