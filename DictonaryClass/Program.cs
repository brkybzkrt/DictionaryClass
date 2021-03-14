using System;
using System.Collections.Generic;

namespace DictonaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();

            sehirler.Add(26, "Eskişehir");

            Console.WriteLine(sehirler.Count);

            Console.WriteLine("*******************************************************");

            MyDictionary<int, string> sehirler2 = new MyDictionary<int, string>();

            sehirler2.Ekle(34, "İstanbul");


            Console.WriteLine(sehirler2.Length);
           
        }
    }
}
