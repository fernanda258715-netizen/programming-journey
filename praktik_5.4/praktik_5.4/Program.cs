using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Insialisasi variabel penghitungan(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur:");
            //2. Perulangan 'While'
            // Kondisi: Selama nilai'hitunagan' lebiih besar dari 0
            while (hitungan> 0)
            {
                // Blok kode di dalam perulangan
                Console.WriteLine($"Hitungan: {hitungan}");

                //3. Update variabel penghitung (decrement / pengurangan)
                // Ini PENTING agar perulangan tidak menjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                // atau bisa juga ditulis: hitungan--;
            }
            // Kode setelah prtulangan selesai
            Console.WriteLine("Selesai! Hitunagn mundur telah berakhir.");
        }
    }
}
