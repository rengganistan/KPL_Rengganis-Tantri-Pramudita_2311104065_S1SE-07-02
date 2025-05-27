using System;
namespace tpmodul6_2311104065
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh null dan maksimal 100 karakter.");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Play count yang ditambahkan tidak boleh negatif.");
                return;
            }

            if (count > 10000000)
            {
                Console.WriteLine("Jumlah penambahan play count tidak boleh lebih dari 10.000.000.");
                return;
            }

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Jumlah play count melebihi batas maksimal.");
                playCount = int.MaxValue; 
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
            Console.WriteLine();
        }
    }
}



