using System;
using System.Linq;
using System.Collections.Generic;

namespace _0542
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var s = new Dictionary<int,int>();
            for(var i = 0; i <= a; i++){
                for(var j = 0; j <= b; j++){
                    var x = j * 5 + i;
                    if(!s.ContainsKey(x)){
                        s.Add(x,1);
                    }
                }
            }

            foreach(var n in s.Where(t => t.Key != 0).OrderBy(t => t.Key)){
                Console.WriteLine(n.Key);
            }
        }
    }
}
