using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TpModul7_Kelompok_7_
{
    public class Nama
    {
        public string depan { get; set; }
        public string tengah { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
        public string prodi { get; set; }
    }

    public class DataMahasiswa2311104049
    {
        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_1_2311104049.json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    Console.WriteLine("Lokasi pencarian: " + Path.GetFullPath(filePath));
                    return;
                }

                // Baca dan deserialize file JSON
                string jsonString = File.ReadAllText(filePath);
                DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

                // Cek apakah data null setelah deserialisasi
                if (data == null || data.nama == null)
                {
                    Console.WriteLine("Data JSON tidak valid atau kosong.");
                    return;
                }

                // Tampilkan hasil
                Console.WriteLine($"Nama {data.nama.depan} {data.nama.tengah} {data.nama.belakang} " +
                    $"dengan NIM {data.nim} dari Fakultas {data.fakultas} dan Prodi {data.prodi}");
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Error parsing JSON: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
