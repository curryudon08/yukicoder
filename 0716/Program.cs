using System;
using System.Linq;

namespace _0716
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var minV = int.MaxValue;
            var maxV = int.MinValue;
            for(var i = 0; i < n - 1; i++){
                for(var j = i + 1; j < n; j++){
                    var m = Math.Abs(s[j] - s[i]);
                    minV = Math.Min(minV, m);
                    maxV = Math.Max(maxV, m);
                }
            }

            Console.WriteLine(minV);
            Console.WriteLine(maxV);
        }
    }
}
