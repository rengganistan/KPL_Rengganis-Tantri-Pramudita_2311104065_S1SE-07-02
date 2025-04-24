using System;
using System.Text.Json;
using TJm8_2311104065;

namespace modul8_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load configuration
            BankTransferConfig config = BankTransferConfig.LoadConfig();

            // Tampilkan pesan sesuai bahasa
            if (config.Lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            else if (config.Lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            }

            // Baca input jumlah uang
            double transferAmount = 0;
            while (true)
            {
                try
                {
                    transferAmount = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    if (config.Lang == "en")
                    {
                        Console.WriteLine("Please enter a valid number:");
                    }
                    else
                    {
                        Console.WriteLine("Masukkan angka yang valid:");
                    }
                }
            }

            // Hitung biaya transfer
            int transferFee = 0;
            if (transferAmount <= config.Transfer.Threshold)
            {
                transferFee = config.Transfer.LowFee;
            }
            else
            {
                transferFee = config.Transfer.HighFee;
            }

            // Hitung total biaya
            double totalAmount = transferAmount + transferFee;

            // Tampilkan biaya transfer dan total biaya
            if (config.Lang == "en")
            {
                Console.WriteLine($"Transfer fee = {transferFee}");
                Console.WriteLine($"Total amount = {totalAmount}");
            }
            else
            {
                Console.WriteLine($"Biaya transfer = {transferFee}");
                Console.WriteLine($"Total biaya = {totalAmount}");
            }

            // Tampilkan metode transfer
            if (config.Lang == "en")
            {
                Console.WriteLine("Select transfer method:");
            }
            else
            {
                Console.WriteLine("Pilih metode transfer:");
            }

            // Tampilkan daftar metode transfer
            for (int i = 0; i < config.Methods.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {config.Methods[i]}");
            }

            // Baca pilihan metode transfer
            int selectedMethod = 0;
            while (true)
            {
                try
                {
                    selectedMethod = Convert.ToInt32(Console.ReadLine());
                    if (selectedMethod >= 1 && selectedMethod <= config.Methods.Length)
                    {
                        break;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    if (config.Lang == "en")
                    {
                        Console.WriteLine($"Please select a valid method (1-{config.Methods.Length}):");
                    }
                    else
                    {
                        Console.WriteLine($"Pilih metode yang valid (1-{config.Methods.Length}):");
                    }
                }
            }

            // Konfirmasi transaksi
            string confirmationWord = config.Lang == "en" ? config.Confirmation.En : config.Confirmation.Id;
            if (config.Lang == "en")
            {
                Console.WriteLine($"Please type \"{confirmationWord}\" to confirm the transaction:");
            }
            else
            {
                Console.WriteLine($"Ketik \"{confirmationWord}\" untuk mengkonfirmasi transaksi:");
            }

            // Baca konfirmasi
            string confirmation = Console.ReadLine();

            // Cek konfirmasi
            if (confirmation.ToLower() == confirmationWord.ToLower())
            {
                if (config.Lang == "en")
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
            }
            else
            {
                if (config.Lang == "en")
                {
                    Console.WriteLine("Transfer is cancelled");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}