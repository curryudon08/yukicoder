using System;
using System.Linq;
using System.Collections.Generic;

namespace _0851
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var items = new long[n];
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().Split();
                if(s.Length != 1){
                    Console.WriteLine("\"assert\"");
                    return;
                }

                items[i] = long.Parse(s[0]);
            }

            var x = new List<long>();
            x.Add(items[0] + items[1]);
            x.Add(items[0] + items[2]);
            x.Add(items[1] + items[2]);

            var h = new HashSet<long>(x);
            var ans = h.OrderByDescending(t => t).Skip(1).First();
            Console.WriteLine(ans);
        }
    }
}
