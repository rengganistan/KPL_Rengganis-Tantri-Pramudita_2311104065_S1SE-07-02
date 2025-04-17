
using System;
using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    private const string configPath = "covid_config.json";

    public static CovidConfig LoadConfig()
    {
        if (File.Exists(configPath))
        {
            string json = File.ReadAllText(configPath);
            return JsonSerializer.Deserialize<CovidConfig>(json);
        }
        else
        {
            // Nilai default
            return new CovidConfig
            {
                satuan_suhu = "celcius",
                batas_hari_deman = 14,
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
            };
        }
    }

    public void SimpanConfig()
    {
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(configPath, json);
    }

    public void UbahSatuan()
    {
        if (satuan_suhu == "celcius")
            satuan_suhu = "fahrenheit";
        else
            satuan_suhu = "celcius";

        SimpanConfig();
    }
}
