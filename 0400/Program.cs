using System;

namespace _0400
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            for(var i = s.Length - 1; i >= 0; i--){
                if(s[i] == '<'){
                    Console.Write(">");
                }else{
                    Console.Write("<");
                }
            }
            Console.Write("\n");
        }
    }
}
