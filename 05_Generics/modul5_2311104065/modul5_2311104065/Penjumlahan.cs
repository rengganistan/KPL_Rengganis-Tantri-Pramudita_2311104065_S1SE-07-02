using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_2311104065
{
    class Penjumlahan
    {
        // Method generic dengan nama JumlahTigaAngka
        public T JumlahTigaAngka<T>(T a, T b, T c)
        {
            // Gunakan dynamic agar operasi + bisa dilakukan
            dynamic x = a;
            dynamic y = b;
            dynamic z = c;
            return x + y + z;
        }
    }
}
