using System;
using System.Linq;
using System.Collections.Generic;

namespace _0079
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var d = new Dictionary<int,int>();
            for(var i = 0; i < n; i++){
                var t = l[i];
                if(d.ContainsKey(t)){
                    d[t] += 1;
                }else{
                    d.Add(t,1);
                }
            }
            var m = d.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key).First();
            Console.WriteLine(m.Key);
        }
    }
}
