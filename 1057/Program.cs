using System;
using System.Linq;

namespace _1057
{
    class Program
    {
        static void Main(string[] args)
        {
            var ab = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderByDescending(x => x).ToArray();

            if(ab[0] == ab[1]){
                if(ab[0] == 1){
                    Console.WriteLine(1);
                }else{
                    Console.WriteLine((ab[0] - 1) * 2 + 1);
                }
            }else{
                Console.WriteLine(ab[1] * 2);
            }

        }
    }
}
