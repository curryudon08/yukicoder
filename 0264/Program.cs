using System;
using System.Linq;

namespace _0264
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var n = s[0];
            var k = s[1];

            if(n == k){
                Console.WriteLine("Drew");
            }else if(n == 0){
                if(k == 1){
                    Console.WriteLine("Won");
                }else if(k == 2){
                    Console.WriteLine("Lost");
                }
            }else if(n == 1){
                if(k == 0){
                    Console.WriteLine("Lost");
                }else if(k == 2){
                    Console.WriteLine("Won");
                }
            }else if(n == 2){
                if(k == 0){
                    Console.WriteLine("Won");
                }else if(k == 1){
                    Console.WriteLine("Lost");
                }
            }
        }
    }
}
