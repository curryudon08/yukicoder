using System;
using System.Linq;

namespace _9012
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(',').Select(i => int.Parse(i)).Sum();
            Console.WriteLine(string.Format("a + b = {0}",s));
        }
    }
}
