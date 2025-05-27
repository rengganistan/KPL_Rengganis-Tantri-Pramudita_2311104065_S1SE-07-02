using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan satu huruf: ");
        char huruf = Convert.ToChar(Console.ReadLine());

        char[] vokal = { 'A', 'I', 'U', 'E', 'O' };

        if (Array.Exists(vokal, element => element == huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }
    }
}
