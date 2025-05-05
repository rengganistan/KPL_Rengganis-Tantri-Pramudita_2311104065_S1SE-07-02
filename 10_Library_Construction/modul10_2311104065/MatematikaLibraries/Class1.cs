using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        // A. Mencari FPB
        public int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        // B. Mencari KPK
        public int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        // C. Menghitung Turunan
        public string Turunan(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koefisien = persamaan[i];
                int turunan = koefisien * pangkat;

                if (turunan == 0)
                {
                    pangkat--;
                    continue;
                }

                if (result.Length > 0)
                {
                    result.Append(turunan > 0 ? " + " : " - ");
                }
                else if (turunan < 0)
                {
                    result.Append("-");
                }

                result.Append(Math.Abs(turunan));
                if (pangkat - 1 > 1)
                    result.Append("x" + (pangkat - 1));
                else if (pangkat - 1 == 1)
                    result.Append("x");

                pangkat--;
            }

            return result.ToString();
        }

        // D. Menghitung Integral
        public string Integral(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int koefisien = persamaan[i];
                int pangkatBaru = pangkat - i;

                double integral = (double)koefisien / pangkatBaru;

                if (integral == 0) continue;

                if (result.Length > 0)
                {
                    result.Append(integral > 0 ? " + " : " - ");
                }
                else if (integral < 0)
                {
                    result.Append("-");
                }

                double absIntegral = Math.Abs(integral);
                if (absIntegral == 1)
                    result.Append("x");
                else
                    result.Append(absIntegral.ToString("0.##") + "x");

                if (pangkatBaru > 1)
                    result.Append(pangkatBaru);
            }

            result.Append(" + C");
            return result.ToString();
        }
    }
}
