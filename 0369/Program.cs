using System;
using System.Linq;
using System.Collections.Generic;

namespace _0369
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();
            var v = int.Parse(Console.ReadLine());

            Console.WriteLine(s - v);
        }
    }
}
