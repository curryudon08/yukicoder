using System;

namespace _0128
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());

            var x = (n / 1000) / k;
            Console.WriteLine(x * 1000);
        }
    }
}
