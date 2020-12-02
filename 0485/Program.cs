using System;

namespace _0485
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            if(b % a == 0){
                Console.WriteLine(b / a);
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
