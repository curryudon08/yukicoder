using System;
using System.Linq;
using System.Collections.Generic;

namespace _0750
{
    class Program
    {
        static void Main(string[] args)
        {
            var l =  new List<(int, int, double)>();

            var n = int.Parse(Console.ReadLine());
            foreach(var i in Enumerable.Range(0, n)){
                var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                l.Add((s[0], s[1], s[0] * 1.0 / s[1]));
            }

            foreach(var t in l.OrderByDescending(x => x.Item3)){
                Console.WriteLine(string.Format("{0} {1}", t.Item1, t.Item2));
            }            
        }
    }
}
