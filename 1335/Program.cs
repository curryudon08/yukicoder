using System;
using System.Linq;

namespace _1335
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var s = Console.ReadLine();

            var r = new string[s.Length];
            for(var i = 0; i < s.Length; i++){
                var x = s[i];
                if(char.IsNumber(x)){                    
                    r[i] = a[int.Parse(x.ToString())].ToString();
                }else{
                    r[i] = x.ToString();
                }
            }

            Console.WriteLine(r.Aggregate((a, b) => a + b));
        }
    }
}
