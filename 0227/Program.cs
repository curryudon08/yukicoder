using System;
using System.Collections.Generic;
using System.Linq;

namespace _0227
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var d = new Dictionary<int,int>();
            for(var i = 0; i < s.Length; i++){
                var n = s[i];
                if(d.ContainsKey(n)){
                    d[n] += 1;
                }else{
                    d.Add(n,1);
                }
            }
            var h = string.Join("",d.OrderBy(x => x.Value).Select(x => x.Value.ToString()));

            if(h.Equals("23")){
                Console.WriteLine("FULL HOUSE");
            }else if(h.Equals("113")){
                Console.WriteLine("THREE CARD");
            }else if(h.Equals("122")){
                Console.WriteLine("TWO PAIR");
            }else if(h.Equals("1112")){
                Console.WriteLine("ONE PAIR");
            }else{
                Console.WriteLine("NO HAND");
            }
        }
    }
}
