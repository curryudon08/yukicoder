using System;
using System.Linq;

namespace _0799
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var red = Enumerable.Range(s[0], s[1] - s[0] + 1);
            var black = Enumerable.Range(s[2], s[3] - s[2] + 1);

            var cnt = red.Count() * black.Count() - red.Intersect(black).Count();
            Console.WriteLine(cnt);
        }
    }
}
