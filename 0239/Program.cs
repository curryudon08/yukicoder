using System;
using System.Linq;
using System.Collections.Generic;

namespace _0239
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = new List<string[]>();
            foreach(var i in Enumerable.Range(0,n)){
                var s = Console.ReadLine().Split().ToArray();
                a.Add(s);
            }

            var b = new List<HashSet<string>>();
            foreach(var i in Enumerable.Range(0,n)){
                var s = Enumerable.Range(0,n).Where(j => !a[j][i].Equals("-")).Select(j => a[j][i]).ToArray().ToHashSet();
                //Console.WriteLine(string.Join("",s));
                b.Add(s);
            }

            var ans = new List<int>();
            foreach(var i in Enumerable.Range(0,n)){
                if(b[i].Count == 1 && b[i].First().Equals("nyanpass")){
                    ans.Add(i + 1);
                }
            }

            if(ans.Count == 1){
                Console.WriteLine(ans[0]);
            }else{
                Console.WriteLine(-1);
            }
        }
    }
}
