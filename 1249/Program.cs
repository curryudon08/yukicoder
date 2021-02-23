using System;

namespace _1249
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = long.Parse(_[0]);
            var b = long.Parse(_[1]);
            var c = long.Parse(_[2]);

            Console.WriteLine(a + b == c ? "Correct" : "Incorrect");
        }
    }
}
