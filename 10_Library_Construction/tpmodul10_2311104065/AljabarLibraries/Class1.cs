using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Fungsi untuk mencari akar-akar persamaan kuadrat
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double diskriminan = b * b - 4 * a * c;

            if (diskriminan < 0)
            {
                Console.WriteLine("Tidak memiliki akar real.");
                return new double[0];
            }

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        // Fungsi untuk mengkuadratkan persamaan linier (ax + b)^2
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;        // a^2
            double ab2 = 2 * a * b;   // 2ab
            double b2 = b * b;        // b^2

            return new double[] { a2, ab2 * -1, b2 }; // karena bentuk: a^2x^2 - 2abx + b^2
        }
    }
}
