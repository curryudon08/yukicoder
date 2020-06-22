using System;

namespace _0920
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var y = int.Parse(_[1]);
            var z = int.Parse(_[2]);

            var diff = x >= y ? x - y : y - x;

            if(z >= diff){
                var count = ((z - diff) / 2) + Math.Max(x,y);
                Console.WriteLine(count);
            }else{
                var count = z + Math.Min(x,y);
                Console.WriteLine(count);
            }
        }
    }
}
