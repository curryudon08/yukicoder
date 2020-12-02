using System;
using System.Linq;

namespace _0637
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var cnt = 0;
            foreach(var n in s){
                if(n % 3 == 0 && n % 5 == 0){
                    cnt += "FizzBuzz".Length;
                }else if(n % 3 == 0){
                    cnt += "Fizz".Length;
                }else if(n % 5 == 0){
                    cnt += "Buzz".Length;
                }else{
                    cnt += n.ToString().Length;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
