using System;

namespace _0804
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var c = int.Parse(_[2]);
            var d = int.Parse(_[3]);

            var y = 0;
            for(var i = 0; i < d / (1 + c); i++){
                if(a >= 1 && b >= c){
                    y++;
                    a--;
                    b -= c;
                }
            }

            Console.WriteLine(y);
        }
    }
}
