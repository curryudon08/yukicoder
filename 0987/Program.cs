using System;
using System.Linq;
using System.Collections.Generic;

namespace _0987
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var __ = Console.ReadLine().Split();
            var op = __[0];
            var s = __.Skip(1).Select(t => long.Parse(t)).ToArray();

            for(var i = 0; i < n; i++){
                var x = long.Parse(Console.ReadLine());

                var a = new long[m];
                for(var j = 0; j < m; j++){
                    if(op.Equals("+")){
                        a[j] = s[j] + x;
                    }else{
                        a[j] = s[j] * x;
                    }
                }
                Console.WriteLine(string.Join(" ",a.Select(t => t.ToString())));
            }
        }
    }
}
