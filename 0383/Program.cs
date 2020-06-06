using System;
using System.Linq;

namespace _0383
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var a = s[0];
            var b = s[1];
            var sub = b - a;

            if(sub <= 0){
                Console.WriteLine(sub);
            }else{
                Console.WriteLine(string.Format("+{0}",sub));
            }
        }
    }
}
