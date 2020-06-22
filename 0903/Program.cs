using System;

namespace _0903
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0:F10}",1.0 / n));
        }
    }
}
