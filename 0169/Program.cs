using System;

namespace _0169
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            var d = (s * 1.0 / (100 - k) * 100);
            Console.WriteLine(string.Format("{0}",Math.Floor(d)));
        }
    }
}
