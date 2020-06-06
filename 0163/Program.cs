using System;
using System.Linq;
using System.Collections.Generic;

namespace _0163
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            foreach(var c in s.ToCharArray()){
                Console.Write(char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c));
            }
            Console.WriteLine();
        }
    }
}
