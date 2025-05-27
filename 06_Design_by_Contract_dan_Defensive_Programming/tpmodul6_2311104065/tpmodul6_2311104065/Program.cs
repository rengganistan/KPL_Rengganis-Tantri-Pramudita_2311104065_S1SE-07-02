using tpmodul6_2311104065;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Rengganis");

                for (int i = 0; i < 5; i++)
                {
                    video.IncreasePlayCount(2000000); 
                }

                video.IncreasePlayCount(15000000); 

                video.IncreasePlayCount(int.MaxValue); 
                video.PrintVideoDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
