using System;
using System.Linq;

namespace _0651
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var t = a / 10 * 6;

            var dt = new DateTime(2021,1,1,10,0,0);
            var ts = new TimeSpan(t/60,t%60,0);
            dt += ts;

            Console.WriteLine(string.Format("{0}:{1:D2}",dt.Hour, dt.Minute));
        }
    }
}
