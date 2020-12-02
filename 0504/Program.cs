using System;
using System.Linq;

namespace _0504
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var a = long.Parse(Console.ReadLine());
            var p = 1;
            
            var s = new long[n];
            s[0] = p;

            for(var i = 0; i < n - 1; i++){
                var t = long.Parse(Console.ReadLine());
                if(t > a){
                    p++;
                }
                s[i+1] = p;
            }

            Console.WriteLine(string.Join("\n",s.Select(x => x.ToString())));
        }
    }
}
