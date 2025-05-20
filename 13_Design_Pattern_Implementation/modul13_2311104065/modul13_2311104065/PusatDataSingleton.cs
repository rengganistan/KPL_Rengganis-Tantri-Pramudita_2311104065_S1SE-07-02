using System;
using System.Collections.Generic;

namespace modul13_2311104065
{
    public class PusatDataSingleton
    {
        // Tambahkan tanda tanya (?) agar field ini nullable
        private static PusatDataSingleton? _instance;

        public List<string> DataTersimpan { get; set; }

        // Konstruktor privat
        private PusatDataSingleton()
        {
            DataTersimpan = new List<string>();
        }

        // Method Singleton
        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        // Mengembalikan seluruh data
        public List<string> GetSemuaData()
        {
            return DataTersimpan;
        }

        // Menampilkan seluruh data
        public void PrintSemuaData()
        {
            Console.WriteLine("Isi Data:");
            foreach (var data in DataTersimpan)
            {
                Console.WriteLine("- " + data);
            }
        }

        // Menambahkan data
        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
        }

        // Menghapus data
        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < DataTersimpan.Count)
            {
                DataTersimpan.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index tidak valid.");
            }
        }
    }
}
