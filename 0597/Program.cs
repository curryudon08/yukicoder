using System;
using System.Linq;
using System.Collections.Generic;

namespace _0597
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var s = new List<string>();
            foreach(var i in Enumerable.Range(0,n)){
                s.Add(Console.ReadLine().Trim());
            }

            Console.WriteLine(s.Aggregate((a,b) => a + b));
        }
    }
}
