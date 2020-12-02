using System;
using System.Collections.Generic;

namespace _1026
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var head = new List<string>();
            var tail = new List<string>();

            for(var i = 0; i < n; i++){
                var _ = Console.ReadLine().Split();
                var t = int.Parse(_[0]);
                var s = _[1];

                if(t == 0){
                    tail.Add(s);
                }else{
                    head.Add(s);
                }
            }

            head.Reverse();
            var o = string.Join("",head) + string.Join("",tail);

            Console.WriteLine(o);
        }
    }
}
