using System;

namespace _0051
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = long.Parse(Console.ReadLine());
            var d = long.Parse(Console.ReadLine());

            for(var i = d; i > 1; i--){
                w -= (w / (i * i));
            }

            Console.WriteLine(w);
        }
    }
}
