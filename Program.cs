using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih menu aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah penjualan");
            Console.WriteLine("2. Tampilkan penjualan");
            Console.WriteLine("3. Keluar");


            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            int Nota, Total_Nota;
            string Tanggal, Customer, Jenis;

            Console.WriteLine("Tambah data penjualan : ");

            Console.WriteLine();
            Console.Write("Nota : ");
            Nota = int.Parse(Console.ReadLine());
            Console.Write("Tanggal : ");
            Tanggal = Console.ReadLine();
            Console.Write("Customer : ");
            Customer = Console.ReadLine();
            Console.Write("Jenis : ");
            Jenis = Console.ReadLine();
            Console.Write("Total Nota : ");
            Total_Nota = int.Parse(Console.ReadLine());


            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            if (Jenis == "Tunai" || Jenis == "T")
            {
                Jenis = "Tunai";
            }
            if (Jenis == "K" || Jenis == "k")
            {
                Jenis = "kredit";
            }
            daftarPenjualan.Add(new Penjualan() { Nota = Nota, Tanggal = Tanggal, Customer = Customer, Jenis = Jenis, Total_Nota = Total_Nota });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");
            int no = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, daftar.Nota, daftar.Tanggal, daftar.Customer, daftar.Jenis, daftar.Total_Nota);
                no++;
                // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
        }
    }
}
