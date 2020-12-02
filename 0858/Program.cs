using System;
using System.Linq;

namespace _0858
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = long.Parse(_[0]);
            var b = long.Parse(_[1]);

            var x = new long[51];
            x[0] = a / b;
            var r = a % b;

            for(var i = 1; i < 51; i++){
                r *= 10;
                x[i] = r / b;
                r %= b;
            }

            var s = x.First().ToString() + "." + string.Join("",x.Skip(1).Select(n => n.ToString()));
            Console.WriteLine(s);
        }
    }
}
