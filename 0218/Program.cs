using System;

namespace _0218
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            var c = long.Parse(Console.ReadLine());

            var x = a % b == 0 ? a / b : a / b + 1;
            var y = a % c == 0 ? a / c : a / c + 1;

            Console.WriteLine(y * 1.0 / x <= 2.0 / 3 ? "YES" : "NO");
        }
    }
}
