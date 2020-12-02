using System;
using System.Linq;

namespace _0279
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var cnt = new int[3];
            cnt[0] = s.Count(c => c == 't');
            cnt[1] = s.Count(c => c == 'r');
            cnt[2] = s.Count(c => c == 'e') / 2;

            Console.WriteLine(cnt.Min());
        }
    }
}
