using System;
using System.Linq;
using System.Collections.Generic;

namespace _0123
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var l = Enumerable.Range(1,n).ToList();

            for(var i = 0; i < m; i++){
                var t = l[a[i]-1];
                l.Remove(t);
                l.Insert(0,t);
            }

            Console.WriteLine(l[0]);
        }
    }
}
