using System;

namespace _0721
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split('/');
            var y = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var d = int.Parse(_[2]);

            var d1 = new DateTime(y,m,d);
            var d2 = d1.AddDays(2);
            Console.WriteLine(d2.ToShortDateString());
        }
    }
}
