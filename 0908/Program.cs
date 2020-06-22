using System;

namespace _0908
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var f = true;
            for(var i = 1; i <= s.Length; i++){
                if(i % 2 == 0){
                    if(!(s[i-1] == ' ')){
                        f = false;
                        break;
                    }
                }else{
                    if(!(s[i-1] != ' '  && char.IsLower(s[i-1]))){
                        f = false;
                        break;
                    }
                }
            }

            Console.WriteLine(f ? "Yes" : "No");
        }
    }
}
