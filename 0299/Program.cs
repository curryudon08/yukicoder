using System;
using System.Numerics;

namespace _0299
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            BigInteger p = 264 + (n * 52);
            Console.WriteLine(p);
        }
    }
}
