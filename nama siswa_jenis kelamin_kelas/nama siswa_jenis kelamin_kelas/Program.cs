using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nama_siswa_jenis_kelamin_kelas
{
    internal class Program
    {
        static void Main()
        {
            string[] nama = new string[3];
            char[] jeniskelamin = new char[3];
            string[] kelas = new string[3];

            // input data siswa
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Data siswa ke-{i + 1}");
                Console.Write("Nama siswa: ");
                nama[i] = Console.ReadLine();

                Console.Write("Jenis kelamin (L / P: ");
                jeniskelamin[i] = Convert.ToChar(Console.ReadLine());

                Console.Write("Kelas: ");
                kelas[i] = Console.ReadLine();

                Console.WriteLine(); // baris kosong antar siswa

            }

            // Tampilkan data siswa
            Console.WriteLine("=== Data Siswa ===");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Siswa ke-{1 + 1}");
                Console.WriteLine($"Nama {nama[i]}");
                Console.WriteLine($"Jenis Kelamin {jeniskelamin[i]}");
                Console.WriteLine($"Kelas {kelas[i]}");
                Console.WriteLine();
            }
        }
    } 
