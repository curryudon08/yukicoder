using System;
using System.Linq;

namespace _0024
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var l = Enumerable.Range(0,10);
            for(var i = 0; i < n; i++){
                var t = Console.ReadLine().Split();
                var r = t[4];
                var s = t.Take(4).Select(x => int.Parse(x));
                if(r.Equals("YES")){
                    l = s.Intersect(l);
                }else{
                    l = l.Except(s);
                }
            }

            Console.WriteLine(l.First());
        }
    }
}
