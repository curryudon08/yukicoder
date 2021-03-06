using System;

namespace _0687
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(var i = 1; i <= 10; i++){
                var a = i;
                var b = n - i;

                if(a <= 10 && b <= 10){
                    Console.WriteLine(string.Format("{0} {1}", a, b));
                    break;
                }
            }
        }
    }
}
