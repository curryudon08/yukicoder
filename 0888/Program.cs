using System;
using System.Numerics;

namespace _0888
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var x = DivisorSum(n);
            Console.WriteLine(x);
        }

        static BigInteger DivisorSum(long n){
            BigInteger s = 0;
            for(var i = 1L; i * i <= n; i++){
                if(n % i == 0){
                    s += i;
                    if(i * i != n){
                        s += (n / i);
                    }
                }
            }
            return s;
        }
    }
}
