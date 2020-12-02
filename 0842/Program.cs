using System;
using System.Linq;

namespace _0842
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var c = _.Take(6).ToArray();
            var g = _.Last();

            var offset = new int[]{500,100,50,10,5,1};

            for(var i = 0; i < 6; i++){
                var o = offset[i];
                for(var j = c[i]; j > 0; j--){
                    if(g - o >= 0){
                        g -= o;
                    }
                }
            }

            Console.WriteLine(g == 0 ? "YES" : "NO");
        }
    }
}
