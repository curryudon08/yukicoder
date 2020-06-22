using System;
using System.Linq;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);

            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var s = a.Where(x => x >= 0);

            if(s.Any()){
                Console.WriteLine(s.OrderByDescending(x => x).Take(k).Sum());
            }else{
                Console.WriteLine(a.Max());
            }
        }
    }
}
