using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Text.Json;

namespace TJm8_2311104065
{
    public class BankTransferConfig
    {
        public string Lang { get; set; }
        public Transfer Transfer { get; set; }
        public string[] Methods { get; set; }
        public Confirmation Confirmation { get; set; }

        public BankTransferConfig()
        {
            // Set nilai default
            Lang = "en";
            Transfer = new Transfer
            {
                Threshold = 25000000,
                LowFee = 6500,
                HighFee = 15000
            };
            Methods = new string[] { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
            Confirmation = new Confirmation
            {
                En = "yes",
                Id = "ya"
            };
        }

        public static BankTransferConfig LoadConfig()
        {
            BankTransferConfig config = null;
            string configFileName = "bank_transfer_config.json";

            try
            {
                if (File.Exists(configFileName))
                {
                    string jsonString = File.ReadAllText(configFileName);
                    config = JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
                }
                else
                {
                    config = new BankTransferConfig();
                    string jsonString = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(configFileName, jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration: {ex.Message}");
                config = new BankTransferConfig();
            }

            return config;
        }
    }

    public class Transfer
    {
        public long Threshold { get; set; }
        public int LowFee { get; set; }
        public int HighFee { get; set; }
    }

    public class Confirmation
    {
        public string En { get; set; }
        public string Id { get; set; }
    }
}