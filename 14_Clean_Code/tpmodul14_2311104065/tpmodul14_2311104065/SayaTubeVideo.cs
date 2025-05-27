using System;

namespace tpmodul14_2311104065
{
    public class SayaTubeVideo
    {
        // Private fields
        private int _id;
        private string _title;
        private int _playCount;

        // Constructor
        public SayaTubeVideo(string title)
        {
            // Validasi judul
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter.");
            }

            // Inisialisasi ID secara acak
            Random rand = new Random();
            _id = rand.Next(10000, 99999);

            // Set nilai properti
            _title = title;
            _playCount = 0;
        }

        // Method untuk menambah play count
        public void IncreasePlayCount(int count)
        {
            // Validasi input
            if (count > 10000000)
            {
                throw new ArgumentException("Maksimum penambahan play count adalah 10.000.000.");
            }

            try
            {
                checked
                {
                    _playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Terjadi overflow saat menambah play count.");
            }
        }

        // Method untuk menampilkan detail video
        public void PrintVideoDetails()
        {
            Console.WriteLine("===== Video Details =====");
            Console.WriteLine($"ID        : {_id}");
            Console.WriteLine($"Title     : {_title}");
            Console.WriteLine($"Play Count: {_playCount}");
            Console.WriteLine("=========================");
        }
    }
}
