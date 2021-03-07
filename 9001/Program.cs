using System;
using System.Linq;

namespace _9001
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();
            var s = Console.ReadLine();
            Console.WriteLine(string.Format("{0} {1}", n, s));
        }
    }
}
