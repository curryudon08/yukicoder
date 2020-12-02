using System;

namespace _0682
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var cnt = 0;
            for(var i = a; i <= b; i++){
                var x = a + b + i;
                if(x % 3 == 0){
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
