using System;

namespace _0627
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            var p = 0;

            var f = true;
            for(var i = 0; i < t; i++){
                var x = int.Parse(Console.ReadLine());
                if((x == p + 1) || (x == p - 1)){
                    p = x;
                }else{
                    f = false;
                }
            }

            Console.WriteLine(f ? "T" : "F");
        }
    }
}
