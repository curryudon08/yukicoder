using System;
using System.Linq;

namespace _0547
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Split();
            var t = Console.ReadLine().Split();

            for(var i = 0; i < n; i++){
                if(!s[i].Equals(t[i])){
                    Console.WriteLine(i + 1);
                    Console.WriteLine(s[i]);
                    Console.WriteLine(t[i]);
                }
            }
        }
    }
}
