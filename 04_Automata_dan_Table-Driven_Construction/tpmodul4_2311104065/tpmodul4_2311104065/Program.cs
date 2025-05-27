class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        string input;

        Console.WriteLine("=== PENCARIAN KODE POS ===");
        Console.WriteLine("Ketik nama kelurahan (atau ketik 'exit' untuk keluar)\n");

        while (true)
        {
            Console.Write("Nama kelurahan: ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Terima kasih sudah menggunakan program ini.");
                break;
            }

            string hasil = kodePos.GetKodePos(input);
            Console.WriteLine("Kode pos dari \"" + input + "\": " + hasil + "\n");
        }

        // State-based simulation
        Console.WriteLine("\n=== SIMULASI MESIN PINTU ===");
        DoorMachine door = new DoorMachine();

        Console.WriteLine("Tekan ENTER untuk mengubah status pintu...");
        Console.ReadLine();
        door.Toggle();

        Console.WriteLine("Tekan ENTER lagi untuk mengubah status pintu...");
        Console.ReadLine();
        door.Toggle();
    }
}
