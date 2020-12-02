using System;
using System.Numerics;

namespace _0441
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = BigInteger.Parse(_[0]);
            var b = BigInteger.Parse(_[1]);

            var x = a + b;
            var y = a * b;

            if(x > y){
                Console.WriteLine("S");
            }else if(x < y){
                Console.WriteLine("P");
            }else{
                Console.WriteLine("E");
            }
        }
    }
}
