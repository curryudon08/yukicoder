using System;
using System.Numerics;

namespace _1405
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var n = BigInteger.Parse(s);

            var ans = n <= 0 ? 0 : n / 100;
            Console.WriteLine(ans);
        }
    }
}
