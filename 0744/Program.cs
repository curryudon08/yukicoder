using System;

namespace _0744
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "285714";
            var n = int.Parse(Console.ReadLine());

            var c = s[(n - 1) % 6];
            Console.WriteLine(c);
        }
    }
}
