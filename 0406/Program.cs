using System;
using System.Collections.Generic;
using System.Linq;

namespace _0406
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var d = new Dictionary<long,long>();
            var f = true;
            for(var i = 0; i < n; i++){
                var t = s[i];
                if(d.ContainsKey(t)){
                    f = false;
                    break;
                }else{
                    d.Add(t,1);
                }
            }

            if(f){
                var d2 = d.OrderBy(x => x.Value);
                var diff = d2
                for(var i = 1; i < n; i++){
                    var o2 = d2[i];
                }
            }

            Console.WriteLine(f ? "YES" : "NO");
        }
    }
}
