using System;
using System.Linq;
using System.Collections.Generic;

namespace _0070
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var t = Solver(n).Sum();
            Console.WriteLine(t);
        }

        static IEnumerable<double> Solver(int n){
            foreach(var i in Enumerable.Range(0,n)){
                var t = Console.ReadLine().Split();
                var t1 = t[0].Split(':').Select(x => int.Parse(x)).ToArray();
                var t2 = t[1].Split(':').Select(x => int.Parse(x)).ToArray();
                
                TimeSpan ts;
                if(t1[0] > t2[0] || (t1[0] == t2[0] && t1[1] > t2[1])){
                    var dt1 = new DateTime(2020, 1, 1, t1[0], t1[1], 0);
                    var dt2 = new DateTime(2020, 1, 2, t2[0], t2[1], 0);
                    ts = dt2 - dt1;
                }else{
                    var dt1 = new DateTime(2020, 1, 1, t1[0], t1[1], 0);
                    var dt2 = new DateTime(2020, 1, 1, t2[0], t2[1], 0);
                    ts = dt2 - dt1;
                }
                yield return ts.TotalMinutes;
            }
        }
    }
}
