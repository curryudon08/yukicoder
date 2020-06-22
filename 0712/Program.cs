using System;

namespace _0712
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var cnt = 0;
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().Trim();
                for(var j = 0; j < m; j++){
                    if(s[j] == 'W'){
                        cnt += 1;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
