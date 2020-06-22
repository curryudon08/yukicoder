using System;
using System.Linq;

namespace _0656
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var x = 0;
            for(var i = 0; i < s.Length; i++){
                var t = Convert.ToInt32(s[i].ToString());
                x += t == 0 ? 10 : t;
            }

            Console.WriteLine(x);
        }
    }
}
