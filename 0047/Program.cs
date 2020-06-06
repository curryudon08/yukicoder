using System;
using System.Collections.Generic;
using System.Linq;

namespace _0047
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var i = 1;
            var c = 0;
            while(n > i){
                i *= 2;
                c++;
            }
            Console.WriteLine(c);
        }
    }
}
