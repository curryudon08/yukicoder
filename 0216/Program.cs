using System;
using System.Linq;

namespace _0216
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var b = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var s = new int[101];
            for(var i = 0; i < n; i++){
                s[b[i]] += a[i];
            }

            var m = s[0];
            var f = true;
            for(var i = 1; i < 101; i++){
                if(s[i] > m){
                    f = false;
                    break;
                }
            }

            Console.WriteLine(f ? "YES" : "NO");
        }
    }
}
