using System;
using System.Linq;

namespace _0156
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var c = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

            var ans = 0;
            for(var i = 0; i < n; i++){
                m -= c[i];
                ans++;

                if(m <= 0){
                    ans -= m < 0 ? 1 : 0;
                    break;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
