using System;
using System.Linq;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var a = v.Average();

            foreach(var m in v){
                var r = 50 - ((a - m) / 2);
                Console.WriteLine(Math.Floor(r));
            }
        }
    }
}
