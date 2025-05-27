using System;
using AljabarLibraries;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Akar Persamaan Kuadrat ====");
            double[] koefisienKuadrat = { 1, -3, -10 }; // x^2 - 3x - 10
            double[] akar = Aljabar.AkarPersamaanKuadrat(koefisienKuadrat);
            Console.WriteLine($"Akar dari x² - 3x - 10 adalah: {akar[0]} dan {akar[1]}");

            Console.WriteLine("\n==== Hasil Kuadrat dari Persamaan Linier ====");
            double[] persamaanLinier = { 2, -3 }; // 2x - 3
            double[] kuadrat = Aljabar.HasilKuadrat(persamaanLinier);
            Console.WriteLine($"Hasil kuadrat dari (2x - 3): {kuadrat[0]}x² {kuadrat[1]}x + {kuadrat[2]}");
        }
    }
}
