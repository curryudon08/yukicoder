using System;
using System.Linq;
using System.Collections.Generic;

namespace _0207
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var a = s[0];
            var b = s[1];

            for(var i = a; i <= b; i++){
                if(IsThree(i)){
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsThree(int i){
            if(i % 3 == 0){
                return true;
            }
            while(i > 0){
                if(i % 10 == 3){
                    return true;
                }
                i /= 10;
            }
            return false;
        }
    }
}
