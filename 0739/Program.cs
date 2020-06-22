using System;

namespace _0739
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();

            if(s.Length % 2 != 0){
                Console.WriteLine("NO");
            }else{
                var h1 = s.Substring(0,s.Length / 2);
                var h2 = s.Substring(s.Length / 2, s.Length / 2);

                var f = h1.Equals(h2);
                Console.WriteLine(f ? "YES" : "NO");
            }
        }
    }
}
