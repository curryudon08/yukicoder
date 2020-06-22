using System;
using System.Linq;

namespace _0932
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(',').ToArray();
            var f = s.All(x => x.Equals("AC"));
            Console.WriteLine(f ? "Done!" : "Failed...");
        }
    }
}
