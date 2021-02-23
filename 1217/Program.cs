using System;
using System.Linq;

namespace _1217
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "abcdefghijklmnopqrstuvwxyz";
            var s2 = Console.ReadLine();

            for(var i = 0; i < s1.Length; i++){
                if(s1[i] != s2[i]){
                    Console.WriteLine(string.Format("{0}to{1}",s1[i], s2[i]));
                    break;
                }
            }
        }
    }
}
