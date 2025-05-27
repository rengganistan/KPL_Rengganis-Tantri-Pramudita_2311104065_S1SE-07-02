using System;

class Program
{
    static void Main(string[] args)
    {
        // Table-driven section
        Console.WriteLine("=== CARI KODE BUAH ===");
        KodeBuah kodeBuah = new KodeBuah();

        while (true)
        {
            Console.Write("Masukkan nama buah (ketik 'exit' untuk keluar): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break;

            string kode = kodeBuah.GetKodeBuah(input);
            Console.WriteLine($"Kode buah '{input}' adalah: {kode}\n");
        }
    }
}

// === State-based ===
Console.WriteLine("\n=== SIMULASI TOMBOL KARAKTER GAME ===");
PosisiKarakterGame karakter = new PosisiKarakterGame();

Console.WriteLine("Tekan tombol: W = atas, S = bawah, Q = keluar");
while (true)
{
    Console.Write("Input (W/S/Q): ");
    string input = Console.ReadLine().ToUpper();

    if (input == "Q") break;
    else if (input == "W") karakter.TombolW();
    else if (input == "S") karakter.TombolS();
    else Console.WriteLine("Input tidak dikenal");
}
