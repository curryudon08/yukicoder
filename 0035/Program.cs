using System;
using System.Linq;

namespace _0035
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var x1 = 0;
            var x2 = 0;

            for(var i = 0; i < n; i++){
                var a = Console.ReadLine().Split();
                var t = long.Parse(a[0]);
                var s = a[1];

                var m1 = Math.Floor((12.0 * t) / 1000);
                var m2 = s.Length < m1 ? s.Length : m1;
                x1 += (int)m2;
                x2 += s.Length - (int)m2;
            }

            Console.WriteLine(string.Format("{0} {1}",x1, x2));
        }
    }
}
