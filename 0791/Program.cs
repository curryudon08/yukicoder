using System;
using System.Linq;

namespace _0791
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().ToArray();
            
            var f1 = s[0] == '1' && s.Length >= 2;
            var f2 = s.Skip(1).All(c => c == '3');

            Console.WriteLine(f1 && f2 ? s.Length - 1: -1);
        }
    }
}
