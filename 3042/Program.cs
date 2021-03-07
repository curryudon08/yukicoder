using System;
using System.Collections.Generic;
using System.Linq;

namespace _3042
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<(string, string)>();

            var n = int.Parse(Console.ReadLine());
            foreach(var i in Enumerable.Range(0,n)){
                var s = Console.ReadLine().Split();
                l.Add((s[0], s[1]));
            }

            var ls = l.OrderBy(x => x.Item1).ThenBy(x => x.Item2);
            foreach(var t in ls){
                Console.WriteLine(string.Format("{0} {1}",t.Item1, t.Item2));
            }
        }
    }
}
