using System;
using System.Collections.Generic;

namespace _0586
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var d = new Dictionary<int,int>();
            var c = 0;
            for(var i = 0; i < n; i++){
                var r = int.Parse(Console.ReadLine());
                if(d.ContainsKey(r)){
                    c += (p1 + p2);
                }else{
                    d.Add(r,1);
                }
            }

            Console.WriteLine(c);
        }
    }
}
