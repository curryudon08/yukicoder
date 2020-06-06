using System;
using System.Linq;
using System.Collections.Generic;

namespace _0005
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = long.Parse(Console.ReadLine());
            var n = long.Parse(Console.ReadLine());
            var w = Console.ReadLine().Split().Select(i => long.Parse(i)).OrderBy(i => i).ToArray();

            var cnt = 0;
            while(true){
                if(cnt < w.Length && l - w[cnt] >= 0){
                    l -= w[cnt];
                    cnt++;
                }else{
                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
