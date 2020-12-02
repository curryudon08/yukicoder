using System;

namespace _9009
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var t = 0L;
            for(var i = 0; i < n; i++){
                t += long.Parse(Console.ReadLine());
            }

            Console.WriteLine(t);
        }
    }
}
