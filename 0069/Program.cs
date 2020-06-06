using System;
using System.Linq;

namespace _0069
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = string.Join("",Console.ReadLine().ToArray().OrderBy(c => c).ToArray());
            var b = string.Join("",Console.ReadLine().ToArray().OrderBy(c => c).ToArray());
            Console.WriteLine(a.Equals(b) ? "YES" : "NO");
        }
    }
}
