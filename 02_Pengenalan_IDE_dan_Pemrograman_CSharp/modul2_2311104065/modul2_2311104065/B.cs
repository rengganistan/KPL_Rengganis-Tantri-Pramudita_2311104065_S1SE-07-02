using System;

class B
{
    static void Main()
    {
        // Membuat array dengan 50 elemen 
        int[] arr = new int[50];

        // Mengisi array dengan nilai sesuai indexnya 
        for (int i = 0; i < 50; i++)
        {
            arr[i] = i;
        }

        // Menampilkan isi array sesuai aturan 
        for (int i = 0; i < 50; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine(i + " #$#$");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine(i + " ##");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + " $$");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
