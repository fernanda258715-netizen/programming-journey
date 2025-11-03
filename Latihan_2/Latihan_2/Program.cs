using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // mulai dari 1
            int total = 0; // untuk menyimpan hasil jumlah

            while (i <=5) // selama i kurang dari atau sama dengan 5 
            {
                total += i; // tambahkan i ke total
                Console.WriteLine($"Total = (total)");
            }

        }
    }
}
