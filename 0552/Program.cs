using System;
using System.Numerics;

namespace _0552
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var x = BigInteger.Parse(s) * 10;
            Console.WriteLine(x);
        }
    }
}
