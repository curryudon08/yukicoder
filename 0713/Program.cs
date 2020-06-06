using System;
using System.Linq;
using System.Collections.Generic;

namespace _0713
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = GetPrimeNumber(n).Sum();
            Console.WriteLine(s);
        }

        static IEnumerable<long> GetPrimeNumber(long n){
            if(n < 2){
               yield return 0;
            }

            if(n >= 2){
                yield return 2;
            }

            for(var i = 3; i <= n; i += 2){
                var flag = true;
                var sqrtnum = Math.Sqrt(i);
                for(var j = 3; j <= sqrtnum; j += 2){
                    if(i % j == 0){
                        flag = false;
                        break;
                    }
                }
                if(flag){
                    yield return i;
                }
            }
        }
    }
}
