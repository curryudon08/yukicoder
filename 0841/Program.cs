using System;

namespace _0841
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();

            var f1 = s[0].Equals("Sat") || s[0].Equals("Sun");
            var f2 = s[1].Equals("Sat") || s[1].Equals("Sun");

            if(f1 && f2){
                Console.WriteLine("8/33");
            }else if(f1){
                Console.WriteLine("8/32");
            }else{
                Console.WriteLine("8/31");
            }
        }
    }
}
