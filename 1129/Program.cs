using System;
using System.Linq;

namespace _1129
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var a = s[0];
            var b = s[1];
            var c = s[2];
            var d = s[3];

            var winner = "";
            if(a == c){
                if(b == d){
                    winner = "Draw";
                }else{
                    if((b == 0 && d == 1) || (b == 1 && d == 2) || (b == 2 && d == 0)){
                        winner = "null";
                    }else{
                        winner = "tRue";
                    }
                }
            }else{
                winner = a > c ? "null" : "tRue"; 
            }

            Console.WriteLine(winner);
        }
    }
}
