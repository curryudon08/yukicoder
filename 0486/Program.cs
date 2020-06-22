using System;
using System.Linq;

namespace _0486
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().ToArray();

            var e = 0;
            var w = 0;
            for(var i = 0; i < s.Length; i++){
                if(s[i] == 'O'){
                    e += 1;
                    w = 0;
                }else{
                    w += 1;
                    e = 0;
                }

                if(e == 3){
                    break;
                }else if(w == 3){
                    break;
                }
            }

            var o = e == 3 ? "East" : (w == 3 ? "West" : "NA");
            Console.WriteLine(o);
        }
    }
}
