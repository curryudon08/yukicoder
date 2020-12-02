using System;
using System.Linq;

namespace _0889
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sosu = 0;
            for(var i = 2; i <= n; i++){
                if(n % i == 0){
                    sosu++;
                }
            }

            if(sosu == 1){
                Console.WriteLine("Sosu!");
                return;
            }

            for(var i = 2; i <= n; i++){
                var x = i * i;
                if(n == x){
                    Console.WriteLine("Heihosu!");
                    return;
                }

                x = x * i;
                if(n == x){
                    Console.WriteLine("Ripposu!");
                    return;
                }
            }

            if(n != 0){
                var k = Enumerable.Range(1,n-1).Where(t => n % t == 0).Sum();
                if(n == k){
                    Console.WriteLine("Kanzensu!");
                    return;
                }
            }

            Console.WriteLine(n);
        }
    }
}
