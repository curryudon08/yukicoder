using System;
using System.Linq;

namespace _0676
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();

            var a = new char[s.Length];
            for(var i = 0; i < s.Length; i++){
                if(s[i] == 'I' || s[i] == 'l'){
                    a[i] = '1';
                }else if(s[i] == 'O' || s[i] == 'o'){
                    a[i] = '0';
                }else{
                    a[i] = s[i];
                }
            }

            Console.WriteLine(string.Join("",a.Select(x => x.ToString())));
        }
    }
}
