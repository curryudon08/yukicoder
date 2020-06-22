using System;

namespace _0203
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine().Trim();
            var s2 = Console.ReadLine().Trim();
            var s = s1 + s2;

            var m = 0;
            var c = 0;
            for(var i = 0; i < s.Length; i++){
                if(s[i] == 'o'){
                    c += 1;                    
                }else{
                    m = Math.Max(m,c);
                    c = 0;
                }
            }
            m = Math.Max(m,c);

            Console.WriteLine(m);
        }
    }
}
