using System;
using System.Linq;

namespace _0191
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var c = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var s = c.Sum() / 10;

            var ans = c.Where(x => x <= s).Count() * 30;
            Console.WriteLine(ans);
        }
    }
}
