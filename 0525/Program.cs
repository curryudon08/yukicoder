using System;
using System.Linq;

namespace _0525
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Console.ReadLine().Split(':').Select(i => int.Parse(i)).ToArray();            
            var t1 = new DateTime(2020, 1, 1, t[0], t[1], 0);
            var t2 = new TimeSpan(0, 5, 0);
            var t3 = t1 + t2; 

            Console.WriteLine(string.Format("{0:00}:{1:00}",t3.Hour, t3.Minute));
        }
    }
}
