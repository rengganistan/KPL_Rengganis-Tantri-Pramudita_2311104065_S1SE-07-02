using System;

class C
{
    static void Main()
    {
        // Meminta input angka dari pengguna 
        Console.Write("Masukkan angka (1 - 10000): ");
        string nilaiString = Console.ReadLine();

        // Mengonversi input string ke integer 
        int nilaiInt = Convert.ToInt32(nilaiString);

        // Memeriksa apakah angka tersebut bilangan prima 
        bool isPrima = CekBilanganPrima(nilaiInt);

        // Menampilkan hasil 
        if (isPrima)
        {
            Console.WriteLine("Angka " + nilaiInt + " merupakan bilangan prima.");
        }
        else
        {
            Console.WriteLine("Angka " + nilaiInt + " bukan merupakan bilangan prima.");
        }
    }

    // Fungsi untuk mengecek apakah bilangan prima 
    static bool CekBilanganPrima(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
