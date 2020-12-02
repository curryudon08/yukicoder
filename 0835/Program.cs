using System;

namespace _0835
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = n * 1.5;
            Console.WriteLine(Math.Floor(m));
        }
    }
}
