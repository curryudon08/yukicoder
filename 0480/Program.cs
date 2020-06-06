using System;
using System.Linq;

namespace _0480
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Enumerable.Range(1, n).Sum();
            Console.WriteLine(s);
        }
    }
}
