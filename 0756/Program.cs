using System;
using System.Linq;

namespace _0756
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = string.Join("",Enumerable.Range(1,100).Select(x => x.ToString()));

            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(c[n-1]);
        }
    }
}
