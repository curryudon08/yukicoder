using System;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var f = n % 6 == 0 ? "Yes" : "No";
            Console.WriteLine(f);
        }
    }
}
