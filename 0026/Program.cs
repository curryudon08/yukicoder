using System;
using System.Linq;

namespace _0026
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cup = new int[3];
            cup[n-1] = 1;

            var m = int.Parse(Console.ReadLine());
            for(var i = 0; i < m; i++){
                var t = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                var idx1 = t[0] - 1;
                var idx2 = t[1] - 1;

                var tmp = cup[idx1];
                cup[idx1] = cup[idx2];
                cup[idx2] = tmp;
            }

            for(var i = 0; i < 3; i++){
                if(cup[i] == 1){
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}
