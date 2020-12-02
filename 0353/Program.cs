using System;
using System.Linq;

namespace _0353
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => long.Parse(x)).Sum();
            Console.WriteLine(s);
        }
    }
}
