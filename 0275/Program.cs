using System;
using System.Linq;
using System.Collections.Generic;

namespace _0275
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).OrderBy(i => i).ToArray();

            if(n % 2 == 0){
                var m = a[n / 2] + a[(n / 2) - 1];
                Console.WriteLine(string.Format("{0:f1}",m / 2.0));
            }else{
                Console.WriteLine(a[n / 2]);
            }
        }
    }
}
