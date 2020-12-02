using System;

namespace _9008
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split();

            var t = 0L;
            for(var i = 0; i < n; i++){
                t += long.Parse(s[i]);
            }

            Console.WriteLine(t);
        }
    }
}
