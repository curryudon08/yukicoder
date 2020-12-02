using System;
using System.Collections.Generic;
using System.Linq;

namespace _0516
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string,int>();

            for(var i = 0; i < 3; i++){
                var s = Console.ReadLine();
                if(d.ContainsKey(s)){
                    d[s] += 1;
                }else{
                    d.Add(s,1);
                }
            }

            Console.WriteLine(d.OrderByDescending(x => x.Value).First().Key);
        }
    }
}
