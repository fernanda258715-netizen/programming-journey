using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Innsialisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            // 2. Blok 'do while'
            do
            {
                // Tampilkan nilai variabel 'angka' saat ini
                Console.WriteLine(angka);

                // Tambahkan nilai 'anhka' sebanyak 1 (inccrement)
                angka++;

                // Uji kondisi: Loop berlanjutan selama ' angka' kurang dari atau sama dengan 

            } while (angka <= 20);
            Console.WriteLine("Selesai.");
        }
    }
}
