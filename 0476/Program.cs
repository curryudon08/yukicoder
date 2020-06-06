using System;
using System.Linq;
using System.Collections.Generic;

namespace _0476
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => double.Parse(i)).ToArray();
            var n = s[0];
            var a = s[1];
            var x = Console.ReadLine().Split().Select(i => double.Parse(i)).Sum();

            if(x / n == a){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
