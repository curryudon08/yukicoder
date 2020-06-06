using System;
using System.Linq;
using System.Collections.Generic;

namespace _0427
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var a = s[0];
            var b = s[1];
            var r = solve(a, b);

            if((a % r == 0 && b % r == 0) && (a / r == 4 && b / r == 3)){
                Console.WriteLine("TATE");
            }else{
                Console.WriteLine("YOKO");
            }
        }

        static int solve(int a, int b){
            if(a < b){
                var t = a;
                a = b;
                b = t;
            }

            var r = a % b;
            while(r > 0){
                a = b;
                b = r;
                r = a % b;
            }

            return b;
        }
    }
}
