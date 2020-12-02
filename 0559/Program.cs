using System;

namespace _0559
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var cnt = 0;
            var ans = 0;
            for(var i = 0; i < s.Length; i++){
                if(s[i] == 'B'){
                    cnt++;
                }else{
                    ans += cnt;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
