using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih operasi hitung:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nMenu yang anda pilih (1-4): ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1 | pilih == 2 | pilih == 3 | pilih == 4)
            {
                Console.Write("\nInput nilai a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input nilai b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                switch (pilih)
                {
                    case 1: penjumlahan(a, b); break;
                    case 2: pengurangan(a, b); break;
                    case 3: perkalian(a, b); break;
                    case 4: pembagian(a, b); break;
                }
            }
            else
            {
                Console.WriteLine("\nMaaf Menu yang anda pilih tidak tersedia :)");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static void penjumlahan(double a, double b)
        {
            Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, a + b);
        }

        static void pengurangan(double a, double b)
        {
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, a - b);
        }

        static void perkalian(double a, double b)
        {
            Console.WriteLine("Hasil perkalian {0} X {1} = {2}", a, b, a * b);
        }

        static void pembagian(double a, double b)
        {
            Console.WriteLine("Hasil pembagian {0} : {1} = {2}", a, b, a / b);
        }
    }
}
