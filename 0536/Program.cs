using System;
using System.Linq;

namespace _0536
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            if(s.Substring(s.Length-2,2).Equals("ai")){
                Console.WriteLine(s.Substring(0,s.Length-2) + "AI");
            }else{
                Console.WriteLine(s + "-AI");
            }
        }
    }
}
