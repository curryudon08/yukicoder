using System;

namespace _0445
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var x = 50 * a;
            var y = (x * 10) / (2 * b + 8);

            Console.WriteLine(x + y);
        }
    }
}
