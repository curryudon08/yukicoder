using System;

namespace _9010
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = long.Parse(Console.ReadLine());
            var f = (y % 400 == 0) ? true : ((y % 100 == 0) ? false : ((y % 4 == 0) ? true : false));

            Console.WriteLine(f ? "Yes" : "No");
        }
    }
}
