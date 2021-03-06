using System;
using System.Linq;

namespace _0188
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt1 = new DateTime(2015, 1, 1, 0, 0, 0);
            var cnt = 0;
            for(var i = 0; i < 365; i++){
                var ts = new TimeSpan(i,0,0,0);
                var dt2 = dt1 + ts;

                var m = dt2.Month;
                var d = dt2.Day;
                cnt += m == (d / 10) + (d % 10) ? 1 : 0;
            }

            Console.WriteLine(cnt);
        }
    }
}
