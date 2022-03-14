using System;

namespace kalkulator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Kalkulator";

            Console.WriteLine("Menu");

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Pembagian");
            Console.WriteLine("4. Perkalian");
            Console.Write("Pilih Operasi Matematika Yang Kamu Gunakan: ");

            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.Write("* Penjumlahan");

                Console.WriteLine();

                Console.Write("Masukkan angka pertama: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil dari penjumlahan adalah: " + a + " + " + b + " = " + (a + b));
                Console.WriteLine("Tekan apa saja untuk melanjutkan...");
                Console.ReadKey();
            }
            if (pilihan == 2)
            {
                Console.Write("* Pengurangan");

                Console.WriteLine();

                Console.Write("Masukkan angka pertama: ");
                int c = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil dari penjumlahan adalah: " + c + " - " + d + " = " + (c - d));

                Console.WriteLine("Tekan apa saja untuk melanjutkan...");
                Console.ReadKey();
            }
            if (pilihan == 3)
            {
                Console.Write("* Pembagian");

                Console.WriteLine();

                Console.Write("Masukkan angka pertama: ");
                int e = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil dari penjumlahan adalah: " + e + " / " + f + " = " + (e / f));

                Console.WriteLine("Tekan apa saja untuk melanjutkan...");
                Console.ReadKey();
            }
            if (pilihan == 4)
            {
                Console.Write("* Perkalian");

                Console.WriteLine();

                Console.Write("Masukkan angka pertama: ");
                int g = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                int h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil dari penjumlahan adalah: " + g + " * " + h + " = " + (g * h));

                Console.WriteLine("Tekan apa saja untuk melanjutkan...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Maaf, pilihan yang anda masukkan tidak terdefinisi!");
                Console.ReadKey();
            }
        }
    }
}

