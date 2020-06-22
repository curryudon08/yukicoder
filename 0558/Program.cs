using System;

namespace _0558
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var f = s.Contains("575");
            Console.WriteLine(f ? "YES" : "NO");
        }
    }
}
