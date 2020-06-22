using System;

namespace _0388
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var s = int.Parse(_[0]);
            var f = int.Parse(_[1]);

            var k = s / f + 1;
            Console.WriteLine(k);
        }
    }
}
