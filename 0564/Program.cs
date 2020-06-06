using System;
using System.Linq;
using System.Collections.Generic;

namespace _0564
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var h = s[0];
            var n = s[1];

            var l = new List<int>();
            l.Add(h);

            foreach(var i in Enumerable.Range(0, n - 1)){
                var x = int.Parse(Console.ReadLine());
                l.Add(x);
            }
            l.Sort();
            l.Reverse();

            var idx = l.IndexOf(h) + 1;
        
            var ans = idx.ToString();
            if(idx % 10 == 1){
                ans += "st";
            }else if(idx % 10 == 2){
                ans += "nd";
            }else if(idx % 10 == 3){
                ans += "rd";
            }else{
                ans += "th";
            }

            Console.WriteLine(ans);
        }
    }
}
