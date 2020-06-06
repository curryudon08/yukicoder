using System;
using System.Linq;
using System.Collections.Generic;

namespace _0481
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = Enumerable.Range(1,10).ToArray();
            Console.WriteLine(string.Join(',', n.Except(s)));
        }
    }
}
