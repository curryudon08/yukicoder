using System;

namespace _0700
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var f = false;
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().Trim();
                if(s.Contains("LOVE")){
                    f = true;
                    break;
                }
            }

            Console.WriteLine(f ? "YES" : "NO");
        }
    }
}
