using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _0666
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => BigInteger.Parse(i)).ToArray();
            var r = (s[0] * s[1]) % 1000000007;
            Console.WriteLine(r);
        }
    }
}
