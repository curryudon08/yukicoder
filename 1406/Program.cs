using System;
using System.Linq;

namespace _1406
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine()); 
            var a = n == 1 ? 0 : Console.ReadLine().Split().Select(x => long.Parse(x)).Sum();

            var cnt = 0;
            for(var i = 0; i <= 100; i++){
                cnt += ((a + i) % n == 0) ? 1 : 0;
            }

            Console.WriteLine(cnt);
        }
    }
}
