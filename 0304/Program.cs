using System;

namespace _0304
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 1000; i++){
                Console.WriteLine(string.Format("{0:000}",i));

                var s = Console.ReadLine().Trim();
                if(s.Equals("unlocked")){
                    break;
                }
            }
        }
    }
}
