using System;


namespace _993
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var o = new string[s.Length];
            for(var i = 0; i < s.Length;){
                if(i !=  s.Length - 1 && s[i] == 'a' && s[i + 1] == 'o'){
                    o[i] = "k";
                    o[i+1] = "i";
                    i += 2;
                }else{
                    o[i] = s[i].ToString();
                    i += 1;
                }
            }

            Console.WriteLine(string.Join("",o));
        }
    }
}
