using System;
using System.Linq;
using System.Collections.Generic;

namespace _0969
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new List<int>(){0,4,10};

            var x = int.Parse(Console.ReadLine());
            if(d.Contains(x)){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
