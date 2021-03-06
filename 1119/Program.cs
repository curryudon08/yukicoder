using System;
using System.Linq;

namespace _1119
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            var f = false;
            foreach(var x in s){
                if(x % 3 == 0){
                    f = true;
                    break;
                }
            }

            Console.WriteLine(f ? "Yes": "No");
        }
    }
}
