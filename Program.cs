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







    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 40));
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(40);
            data.printAllData();

        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T inputsatu, T inputdua, T inputtiga)
        {
            dynamic jumlah1 = inputsatu;
            dynamic jumlah2 = inputdua;
            dynamic jumlah3 = inputtiga;

            return jumlah1 + jumlah2 + jumlah3;

        }

    }
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("data" + i + "isi :" + storedData[i].ToString() + "disimpan pada waktu" + i);
            }
        }
    }
}