using System;

namespace _1128
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            
            Console.WriteLine(n % 2 == 0 ? n + 1: n);
        }
    }
}
