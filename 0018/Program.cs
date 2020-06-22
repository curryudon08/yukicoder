using System;
using System.Linq;

namespace _0018
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var ins = Console.ReadLine().Trim();

            var outs = new char[ins.Length];
            for(var i = 0; i < ins.Length; i++){
                var x = s.IndexOf(ins[i]);
                var j = i % 26;
                var t = x - (j + 1) < 0 ? x - (j + 1) + 26 : x - (j + 1);
                outs[i] = s[t];
            }

            Console.WriteLine(string.Join("",outs.Select(c => c.ToString())));
        }
    }
}
