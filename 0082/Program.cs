using System;

namespace _0082
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var w = int.Parse(_[0]);
            var h = int.Parse(_[1]);
            var c = _[2];

            var m1 = c.Equals("B") ? "BW" : "WB";
            var m2 = c.Equals("B") ? "WB" : "BW";

            for(var i = 0; i < h; i++){
                for(var j = 0; j < w; j++){
                    if(i % 2 == 0){
                        Console.Write(m1[j % 2]);
                    }else{
                        Console.Write(m2[j % 2]);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
