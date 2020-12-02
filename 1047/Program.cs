using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = long.Parse(_[0]);
            var b = long.Parse(_[1]);

            if(b == 0){
                Console.WriteLine(1);
            }else if(a == -1){
                Console.WriteLine(2);
            }else{
                Console.WriteLine(-1);
            }
        }
    }
}
