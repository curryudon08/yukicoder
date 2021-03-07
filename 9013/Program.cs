using System;
using System.Linq;

namespace _9013
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(',').Select(i => int.Parse(i)).ToArray();
            var s = (a[0] + a[1]) * a[2] / 2.0;

            Console.WriteLine(string.Format("{0:F2}",s));
        }
    }
}
