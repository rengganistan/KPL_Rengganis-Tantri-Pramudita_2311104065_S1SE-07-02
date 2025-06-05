using System;
using modul14_2311104065; // Tambahkan ini agar bisa akses class lain

public class Program
{
    public static void Main(string[] args)
    {
        // === Table-driven: Cari Kode Buah ===
        Console.WriteLine("=== CARI KODE BUAH ===");
        KodeBuah kodeBuah = new KodeBuah();

        while (true)
        {
            Console.Write("Masukkan nama buah (ketik 'exit' untuk keluar): ");
            string inputBuah = Console.ReadLine();

            if (string.Equals(inputBuah, "exit", StringComparison.OrdinalIgnoreCase))
                break;

            string kode = kodeBuah.GetKodeBuah(inputBuah);
            Console.WriteLine($"Kode buah '{inputBuah}' adalah: {kode}\n");
        }

        // === State-based: Simulasi Tombol Karakter Game ===
        Console.WriteLine("\n=== SIMULASI TOMBOL KARAKTER GAME ===");
        PosisiKarakterGame karakter = new PosisiKarakterGame();

        Console.WriteLine("Tekan tombol: W = atas, S = bawah, Q = keluar");

        while (true)
        {
            Console.Write("Input (W/S/Q): ");
            string inputArah = Console.ReadLine()?.Trim().ToUpper();

            if (inputArah == "Q")
                break;
            else if (inputArah == "W")
                karakter.TekanTombolAtas();
            else if (inputArah == "S")
                karakter.TekanTombolBawah();
            else
                Console.WriteLine("Input tidak dikenal");
        }
    }
}
