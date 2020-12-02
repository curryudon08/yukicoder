using System;

namespace _0646
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(var i = n; i > 0; i--){
                for(var j = i; j > 0; j--){
                    Console.Write(n);
                }
                Console.Write("\n");
            }
        }
    }
}
