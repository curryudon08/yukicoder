using System;

namespace _0337
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var p = int.Parse(_[1]);
        
            Console.WriteLine(p == n * p ? "=" : "!=");
        }
    }
}
