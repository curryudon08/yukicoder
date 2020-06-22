using System;

namespace _0431
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var d1 = int.Parse(_[0]);
            var d2 = int.Parse(_[1]);
            var d3 = int.Parse(_[2]);
            var s = int.Parse(_[3]);

            var f = (d1 + d2 + d3 < 2) || (s == 1);
            Console.WriteLine(f ? "SURVIVED" : "DEAD");
        }
    }
}
