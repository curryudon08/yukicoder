using System;
using System.Linq;
using System.Collections.Generic;

namespace _0143
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var k = s[0];
            var n = s[1];
            var f = s[2];
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            if(k * n >= a.Sum()){
                Console.WriteLine(k * n - a.Sum());
            }else{
                Console.WriteLine(-1);
            }
        }
    }
}
