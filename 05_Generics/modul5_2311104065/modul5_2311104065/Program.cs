using modul5_2311104065;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // === Input angka dari NIM ===
        // NIM kamu: 2311104065 → ambil tiga dua-digit angka: 11, 04, 06
        // Karena NIM berakhiran 5 → gunakan tipe data double

        double angka1 = 11;
        double angka2 = 4;
        double angka3 = 6;

        // Panggil method generic
        Penjumlahan penjumlahan = new Penjumlahan();
        double hasil = penjumlahan.JumlahTigaAngka<double>(angka1, angka2, angka3);

        Console.WriteLine("=== Hasil Penjumlahan Generic Method ===");
        Console.WriteLine($"Hasil penjumlahan: {hasil}");

        // Gunakan SimpleDataBase untuk menyimpan data dan waktu input
        SimpleDataBase<double> database = new SimpleDataBase<double>();

        database.AddNewData(angka1);
        Thread.Sleep(1000); // agar timestamp berbeda
        database.AddNewData(angka2);
        Thread.Sleep(1000);
        database.AddNewData(angka3);

        Console.WriteLine("\n=== Data yang Disimpan di SimpleDataBase ===");
        database.PrintAllData();
    }
}
