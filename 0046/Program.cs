using System;
using System.Linq;

namespace _0046
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var a = n[0];
            var b = n[1];

            var c = 0;
            while(b > 0){
                b -= a;
                c++;
            }
            Console.WriteLine(c);
        }
    }
}
