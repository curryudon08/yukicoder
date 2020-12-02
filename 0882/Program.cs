using System;
using System.Collections.Generic;

namespace _0882
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = long.Parse(_[0]);
            var b = long.Parse(_[1]);

            var l = Divisor(a);
            var f = false;
            foreach(var x in l){
                if(x % b == 0){
                    f = true;
                    break;
                }
            }

            Console.WriteLine(f ? "YES" : "NO");
        }

        static List<long> Divisor(long n){
            var l = new List<long>();
            for(var i = 1L; i * i <= n; i++){
                if(n % i == 0){
                    l.Add(i);
                    if(i * i != n){
                        l.Add(n / i);
                    }
                }
            }
            l.Sort();
            return l;
        }
    }
}
