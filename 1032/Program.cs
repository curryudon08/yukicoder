using System;
using System.Linq;
using System.Collections.Generic;

namespace _1032
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var m = long.Parse(_[1]);
            var s = Console.ReadLine().Split().Select(x => long.Parse(x)).ToArray();

            var d = new Dictionary<long,long>();
            for(var i = 0; i < n; i++){
                var t = s[i];
                if(d.ContainsKey(t)){
                    d[t] += 1;
                }else{
                    d.Add(t,1);
                }
            }

            for(var i = 1; i <= m; i++){
                if(d.ContainsKey(i)){
                    Console.WriteLine(string.Format("{0} {1}",i,d[i]));
                }else{
                    Console.WriteLine(string.Format("{0} {1}",i,0));
                }
            }
        }
    }
}
