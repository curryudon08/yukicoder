using System;
using System.Linq;
using System.Collections.Generic;

namespace _0056
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
            var d = s[0] * 100;
            var p = s[1] + 100;
            Console.WriteLine(Math.Truncate(d * p / 10000.0));
        }
    }
}
