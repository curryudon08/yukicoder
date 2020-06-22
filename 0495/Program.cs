using System;
using System.Linq;


namespace _0495
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var x = s.Replace("^^*","0").Replace("*^^","1");
            

            var a = 0;
            var b = 0;
            foreach(var c in x){
                if(c == '0'){
                    a += 1;
                }else if(c == '1'){
                    b += 1;
                }
            }

            Console.WriteLine(string.Format("{0} {1}",a,b));
        }
    }
}
