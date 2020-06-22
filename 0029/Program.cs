using System;
using System.Linq;
using System.Collections.Generic;

namespace _0029
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var d = new Dictionary<int,int>();

            var p = 0;
            for(var i = 0; i < n; i++){
                var t = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for(var j = 0; j < 3; j++){
                    var m = t[j];
                    if(d.ContainsKey(m)){
                        d[m] += 1;
                        if(d[m] == 2){
                            p += 1;
                            d[m] = 0;
                        }
                    }else{
                        d.Add(m,1);
                    }
                }
            }

            var s = d.Sum(x => x.Value);
            Console.WriteLine(s / 4 + p);
        }
    }
}
