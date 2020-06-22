using System;

namespace _0857
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = long.Parse(_[0]);
            var y = long.Parse(_[1]);
            var z = long.Parse(_[2]);

            var a = z;
            if(x <= z){
                a -= 1;
            }
            if(y <= z){
                a -= 1;
            }

            Console.WriteLine(a);
        }
    }
}
