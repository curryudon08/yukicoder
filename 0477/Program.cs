using System;
using System.Numerics;

namespace _0477
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = BigInteger.Parse(_[0]);
            var k = BigInteger.Parse(_[1]);

            var x = n / (k + 1) + 1;
            Console.WriteLine(x);
        }
    }
}
