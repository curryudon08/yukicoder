using System;

namespace _0734
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = long.Parse(_[0]) * 60;
            var b = long.Parse(_[1]);
            var c = long.Parse(_[2]) * 60 * 60;

            if(a < b){
                Console.WriteLine(-1);
            }else{
                
            }
        }
    }
}
