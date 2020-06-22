using System;
using System.Collections.Generic;
using System.Linq;

namespace _3020
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var o = "YEAH!".ToCharArray().Select(c => s.Count(i => i == c)).ToArray();
            Console.WriteLine(o.Select(i => i.ToString()).Aggregate((a,b) => a + " " + b));
        }
    }
}
