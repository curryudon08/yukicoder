using System;
using System.Linq;

namespace _0394
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var s = n.Sum() - n.Min() - n.Max();

            Console.WriteLine(string.Format("{0:F2}",s * 1.0 / 4));
        }
    }
}
