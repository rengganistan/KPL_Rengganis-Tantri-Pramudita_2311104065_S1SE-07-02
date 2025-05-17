using tpmodul14_2311104065;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Membuat objek video baru dengan judul tertentu
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rengganis Tantri Pramudita");

            // Menampilkan detail video pertama kali
            video.PrintVideoDetails();

            // Menambahkan jumlah tayangan sebanyak 5000
            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();

            // Menambahkan jumlah tayangan sebanyak 10 juta
            video.IncreasePlayCount(10000000);
            video.PrintVideoDetails();

            // Menambahkan jumlah tayangan sebanyak 20 juta
            video.IncreasePlayCount(20000000);

            // Melakukan penambahan 10 juta tayangan sebanyak 1000 kali (loop stress test)
            for (int i = 0; i < 1000; i++)
            {
                video.IncreasePlayCount(10000000);
            }

            // Menampilkan kembali detail video setelah semua penambahan
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            // Menangani error jika terjadi exception
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
