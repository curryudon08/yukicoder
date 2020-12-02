using System;

namespace _0345
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var ans = int.MaxValue;
            for(var i = 0; i < s.Length; i++){
                if(s[i] == 'c'){
                    var cnt = 1;
                    var w = 0;
                    for(var j = i + 1; j < s.Length; j++){
                        cnt++;
                        if(s[j] == 'w'){
                            w++;
                            if(w == 2){
                                ans = Math.Min(ans,cnt);
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(ans != int.MaxValue ? ans: -1);
        }
    }
}
