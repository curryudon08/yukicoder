using System;
using System.Linq;

namespace _1107
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
            var a1 = s[0];
            var a2 = s[1];
            var a3 = s[2];
            var a4 = s[3];

            Console.WriteLine(a1 < a2 && a3 > a4 ? "YES" : "NO");
        }
    }
}
