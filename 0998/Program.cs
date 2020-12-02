using System;
using System.Linq;

namespace _0998
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

            if((s[1] == s[0] + 1) && (s[2] == s[1] + 1) && (s[3] == s[2] + 1)){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
