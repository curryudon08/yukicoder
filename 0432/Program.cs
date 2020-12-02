using System;
using System.Linq;
using System.Collections.Generic;

namespace _0432
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = long.Parse(Console.ReadLine());

            for(var i = 0; i < t; i++){
                var s = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToList();
                while(s.Count > 1){
                    var l = new List<int>();
                    for(var j = 0; j < s.Count - 1; j++){
                        var n = s[j] + s[j + 1];
                        l.Add(n >= 10 ? n % 10 + 1 : n);
                    }
                    s = l;
                }
                Console.WriteLine(s.First());
            }
        }
    }
}
