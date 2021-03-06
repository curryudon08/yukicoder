using System;
using System.Linq;

namespace _0296
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = s[0];
            var h = s[1];
            var m = s[2];
            var t = s[3];

            var dt = new DateTime(2021, 1, 1, h, m, 0);

            for(var i = 0; i < n - 1; i++){
                var ts = new TimeSpan(0, t, 0);
                dt += ts;
            }

            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
        }
    }
}
