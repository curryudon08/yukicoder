using System;
using System.Numerics;

namespace _0892
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();

            var a1 = int.Parse(_[0]);
            var b1 = int.Parse(_[1]);
            var a2 = int.Parse(_[2]);
            var b2 = int.Parse(_[3]);
            var a3 = int.Parse(_[4]);
            var b3 = int.Parse(_[5]);

            var s = a1 + a2 + a3;
            Console.WriteLine(s % 2 == 0 ? ":-)" : ":-(");
        }
    }
}
