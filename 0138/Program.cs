using System;
using System.Linq;

namespace _0138
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine().Split('.').Select(x => int.Parse(x)).ToArray();
            var t1 = string.Format("{0:000}",s1[0]) + string.Format("{0:000}",s1[1]) + string.Format("{0:000}",s1[2]);
            var n1 = int.Parse(t1);

            var s2 = Console.ReadLine().Split('.').Select(x => int.Parse(x)).ToArray();
            var t2 = string.Format("{0:000}",s2[0]) + string.Format("{0:000}",s2[1]) + string.Format("{0:000}",s2[2]);
            var n2 = int.Parse(t2);

            if(n2 <= n1){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
