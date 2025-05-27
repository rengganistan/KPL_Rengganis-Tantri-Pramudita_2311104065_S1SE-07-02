using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        // Precondition
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Judul video tidak boleh null atau kosong.");
        if (title.Length > 200)
            throw new ArgumentException("Judul video maksimal 200 karakter.");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // Precondition
        if (count < 0 || count > 25000000)
            throw new ArgumentException("Penambahan play count harus antara 0 dan 25.000.000.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Terjadi overflow saat menambahkan play count: " + e.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video     : " + id);
        Console.WriteLine("Judul Video  : " + title);
        Console.WriteLine("Play Count   : " + playCount);
        Console.WriteLine();
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}
