using System;

namespace _0671
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "1000000007".Length - 2;
            var s2 = Console.ReadLine().Trim().Length - 2;

            Console.WriteLine(Math.Abs(s1-s2));
        }
    }
}
