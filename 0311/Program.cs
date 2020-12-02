using System;
using System.Numerics;

namespace _0311
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            var x = (n / 3 * 2) + (n / 5 * 2);
            Console.WriteLine(x);
        }
    }
}
