using System;
using System.Linq;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Console.ReadLine().ToCharArray();
            var z = c.Count(x => x == '0');

            Console.WriteLine(c.Length - z - 1);
        }
    }
}
