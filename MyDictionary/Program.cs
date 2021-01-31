using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdAdet = new Dictionary<string, int>();
            AdAdet.Add("Telefon", 5);
            AdAdet.Add("Bilgisayar", 3);
            AdAdet.Add("Mouse", 10);
            AdAdet.Add("Klavye", 6);

            foreach (var degeroku in AdAdet)
            {
                Console.WriteLine(degeroku);
            }

            var urun = AdAdet.Count();
            Console.WriteLine();
            Console.WriteLine("Ürün Sayısı :" + urun);

            AdAdet.Remove("Bilgisayar");
            Console.WriteLine();

            foreach (var degeroku in AdAdet)
            {
                Console.WriteLine(degeroku);
            }

        }
    }
}
