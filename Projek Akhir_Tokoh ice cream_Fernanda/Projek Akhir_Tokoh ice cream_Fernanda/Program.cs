using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Text;
namespace
projek_Akhir_Tokoh_ice_cream_Fernanda
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // ===================================================
            // DAFTAR MENU ICE CREAM DENGAN VARIAN RASA DAN HARGA
            // ===================================================
            Console.WriteLine("================================");
            Console.WriteLine("=== SELAMAT DATANG DI TOKOH ICE CRAEAM OLAF ===");
            Console.WriteLine("================================");
            Console.WriteLine("Silakan masukkan nama anda:");
            string nama = Console.ReadLine();
            Console.WriteLine("Halo " + nama);

            Console.WriteLine("Daftar menu dan harga ice craem: ");
            Console.WriteLine("1.Vanilla : Rp 5000");
            Console.WriteLine("2.Coklat : Rp 5000");
            Console.WriteLine("3.Matcha : Rp 7000");
            Console.WriteLine("4.buble gum : Rp 8000");
            Console.WriteLine("Silakan pilih varian rasa ice cream favorite anda: ");

            // ===========================================
            // INPUT PILIHAN VARIAN RASA
            // ===========================================
            int pilih = int.Parse(Console.ReadLine());
            int harga = 0;
            string rasa = "";

            switch (pilih)
            {
                case 1:
                    rasa = "Vanilla";
                    harga = 5000;
                    break;
                case 2:
                    rasa = "Coklat";
                    harga = 5000;
                    break;
                case 3:
                    rasa = "Matcha";
                    harga = 7000;
                    break;
                case 4:
                    rasa = "buble gum";
                    harga = 8000;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia!");
                    return;

            }
            // =============
            // TOPPING
            // =============
            Console.WriteLine("\n==== Pilihan topping ====");
            Console.WriteLine("1.Oreo: Rp 2000");
            Console.WriteLine("2.Kacang: Rp 3000");
            Console.WriteLine("3.Ceres: Rp 1000");
            Console.WriteLine("4.Tanpa topping: Rp 0");
            int pilihTopping = int.Parse(Console.ReadLine());
            int hargaTopping = 0;
            string topping = "";

            switch (pilihTopping)
            {
                case 1:
                    topping = "Oreo";
                    hargaTopping = 2000;
                    break;
                case 2:
                    topping = "Kacang";
                    hargaTopping = 3000;
                    break;
                case 3:
                    topping = "Ceres";
                    hargaTopping = 1000;
                    break;
                case 4:
                    topping = "Tanpa Topping";
                    hargaTopping = 0;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia!");
                    return;
                    
            }
            // ============
            // HITUNG TOTAL
            // ============
            int total = harga + hargaTopping;

            // ===========
            // Diskon
            // ===========
            int diskon = (int)(total * 0.10);
            // 10% diskon
            int totalAkhir = total - diskon;
            Console.WriteLine("\n==== Rincian Pembelian =====");
            Console.WriteLine("Rasa : " + rasa + " (Rp " + harga + ")");
            Console.WriteLine("Topping : " + topping + "(Rp " + harga + ")");
            Console.WriteLine("Subtotal : Rp" + total);
            Console.WriteLine("Diskon 10%: Rp" + diskon);

            Console.WriteLine("==============================");
            Console.WriteLine("Total Bayar : Rp" + totalAkhir);
            Console.WriteLine("==============================");

            // ============
            // PEMBAYARAN
            // ============
            Console.Write("Masukkan uang pembayaran: Rp");
            int bayar = int.Parse(Console.ReadLine());
            int kembalian = bayar - totalAkhir;

            if (kembalian < 0)
            {
                Console.WriteLine("Uang anda kurang!");
            }
            else
            {
                Console.WriteLine("Kembalian: Rp" + kembalian);
            }
            Console.WriteLine("========================================================");
            Console.WriteLine("SELAMAT MENIKMATI DAN JANGAN LUPA DATANG KEMBALI ");
            Console.WriteLine("\nTerimakasih sudah membeli ice cream di tokoh saya!");
            Console.WriteLine("========================================================");
            Console.ReadLine();






        }
    }
}
