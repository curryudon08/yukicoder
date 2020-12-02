using System;

namespace _0926
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = double.Parse(_[0]);
            var b = double.Parse(_[1]);
            var c = double.Parse(_[2]);

            var x = a / b * c;
            Console.WriteLine(string.Format("{0:F8}",x));
        }
    }
}
