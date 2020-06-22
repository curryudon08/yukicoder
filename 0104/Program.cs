using System;

namespace _0104
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var x = 1;
            for(var i = 0; i < s.Length; i++){
                x = (s[i] == 'L' ? x * 2 : x * 2 + 1);
            }

            Console.WriteLine(x);
        }
    }
}
