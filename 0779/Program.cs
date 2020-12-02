using System;

namespace _0779
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var y = _[0];
            var m = string.Format("{0:00}", int.Parse(_[1]));
            var d = string.Format("{0:00}", int.Parse(_[2]));

            var ymd = int.Parse(y + m + d);
            Console.WriteLine(ymd >= 19890108 && ymd <= 20190430 ? "Yes" : "No");
        }
    }
}
