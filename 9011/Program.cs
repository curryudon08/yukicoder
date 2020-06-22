using System;
using System.Linq;
using System.Collections.Generic;

namespace _9011
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().Select(i => int.Parse(i.ToString())).Aggregate((i,j) => i+j);
            Console.WriteLine(s);
        }
    }
}
