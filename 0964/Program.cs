using System;

namespace _0964
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var s = new string[n];
            if(n != 10){
                for(var i = 1; i <= n; i++){
                    s[i-1] = new string(Convert.ToChar(i.ToString()),n);
                }
            }else{
                for(var i = 1; i <= n-1; i++){
                    s[i-1] = new string(Convert.ToChar(i.ToString()),n);
                }
                s[n-1] = new string('0',n);
            }

            Console.WriteLine(string.Join("",s));
        }
    }
}
