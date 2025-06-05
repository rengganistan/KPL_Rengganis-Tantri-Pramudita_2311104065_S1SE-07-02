using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul14_2311104065
{
    using System;
    using System.Collections.Generic;

    public class KodeBuah
    {
        // Kamus kode buah berdasarkan nama buah
        private readonly Dictionary<string, string> _tabelKodeBuah = new Dictionary<string, string>
    {
        { "Apel", "A00" },
        { "Aprikot", "B00" },
        { "Alpukat", "C00" },
        { "Pisang", "D00" },
        { "Paprika", "E00" },
        { "Blackberry", "F00" },
        { "Ceri", "H00" },
        { "Kelapa", "I00" },
        { "Jagung", "J00" },
        { "Kurma", "K00" },
        { "Durian", "L00" },
        { "Anggur", "M00" },
        { "Melon", "N00" },
        { "Semangka", "O00" }
    };

        // Mengembalikan kode buah berdasarkan nama
        public string GetKodeBuah(string namaBuah)
        {
            if (string.IsNullOrWhiteSpace(namaBuah))
                return "Nama buah tidak valid";

            return _tabelKodeBuah.TryGetValue(namaBuah, out string kode)
                ? kode
                : "Kode buah tidak ditemukan";
        }
    }

}
