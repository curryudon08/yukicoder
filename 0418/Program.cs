using System;
using System.Linq;

namespace _0418
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Split('n').Length-1);
        }
    }
}
