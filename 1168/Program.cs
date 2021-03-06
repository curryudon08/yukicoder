using System;
using System.Linq;

namespace _1168
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            while(true){
                var n = s.Select(c => int.Parse(c.ToString())).Sum();

                if(n  < 10){
                    Console.WriteLine(n);
                    break;
                }
                s = n.ToString();
            }
        }
    }
}
