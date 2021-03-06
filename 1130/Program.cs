using System;
using System.Linq;
using System.Collections.Generic;

namespace _1130
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            var s1 = new List<int>();

            for(var i = 0; i < hw[0]; i++){
                var a = Console.ReadLine().Split().Select(n => int.Parse(n.ToString())).ToArray();
                foreach(var m in a){
                    s1.Add(m);
                }
            }
            s1.Sort();
        
            for(var i = 0; i < hw[0]; i++){
                var s2 = new int[hw[1]];
                for(var j = 0; j < hw[1]; j++){
                    s2[j] = s1[i * hw[1] + j];
                }
                Console.WriteLine(string.Join(" ", s2.Select(c => c.ToString())));
            }
        }
    }
}
