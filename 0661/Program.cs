using System;

namespace _0661
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(var i = 0; i < n; i++){
                var x = int.Parse(Console.ReadLine());

                if(x % 8 == 0 && x % 10 == 0){
                    Console.WriteLine("ikisugi");
                }else if(x % 8 == 0){
                    Console.WriteLine("iki");
                }else if(x % 10 == 0){
                    Console.WriteLine("sugi");
                }else if(x % 3 == 0){
                    Console.WriteLine(x / 3);
                }
            }
        }
    }
}
