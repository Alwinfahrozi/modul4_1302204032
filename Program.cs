using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            penjumlahan.JumlahTigaAngka<float>(13, 02, 40);
        }
    }

    class penjumlahan
    {
        public static void JumlahTigaAngka<T>(T keluaran1, T keluaran2, T keluaran3)
        {
            dynamic angka1 = keluaran1;
            dynamic angka2 = keluaran2;
            dynamic angka3 = keluaran3;

            Console.WriteLine(angka1 + angka2 + angka3);

                
        }

    }
}