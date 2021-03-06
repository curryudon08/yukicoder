using System;
using System.Linq;
using System.Collections.Generic;

namespace _1155
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<int,string>();
            d.Add(1, "Shiitakerando");
            d.Add(2, "Otsukakokusaibijutsukan");
            d.Add(3, "Spring-8");

            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(d[n]);
        }
    }
}
