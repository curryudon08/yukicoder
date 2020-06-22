using System;

namespace _0815
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var d = n / 2;
            Console.WriteLine(n % 2 == 0 ? d : d + 1);
        }
    }
}
