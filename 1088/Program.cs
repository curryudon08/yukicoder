using System;
using System.Linq;

namespace _1088
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();
            Console.WriteLine(s);
        }
    }
}
