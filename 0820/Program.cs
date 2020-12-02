using System;

namespace _0820
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var k = long.Parse(_[1]);

            if(n - k >= 0){
                var x = Math.Pow(2, n-k);
                Console.WriteLine(x);
            }else{
                Console.WriteLine(0);
            }
        }
    }
}
