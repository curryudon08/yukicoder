using System;
using System.Linq;
using System.Collections.Generic;

namespace _0975
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray()[0];
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var b = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var mrmax = a.Contains(x);
            var maxvalue = b.Contains(x);

            if(mrmax && maxvalue){
                Console.WriteLine("MrMaxValu");
            }else if(mrmax){
                Console.WriteLine("MrMax");
            }else if(maxvalue){
                Console.WriteLine("MaxValu");
            }else{
                Console.WriteLine("-1");
            }
        }
    }
}
