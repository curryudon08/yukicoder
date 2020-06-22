using System;
using System.Linq;

namespace _0185
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var d = new int[n];
            for(var i = 0; i < n; i++){
                var _ = Console.ReadLine().Split();
                var x = int.Parse(_[0]);
                var y = int.Parse(_[1]);

                d[i] = y - x;
            }

            var f = d.First();
            Console.WriteLine(d.All(x => x == f) && f > 0 ? f : -1);
        }
    }
}
