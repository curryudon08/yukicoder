using System;
using System.Linq;

namespace _0773
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var s1 = Enumerable.Range(a, b-a+1);
            var s2 = Enumerable.Range(23, 3);

            Console.WriteLine(3 - s2.Intersect(s1).Count());
        }
    }
}
