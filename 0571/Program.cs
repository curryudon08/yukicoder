using System;
using System.Linq;

namespace _0571
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Tuple<int,int,int>[3];

            for(var i = 0; i < 3; i++){
                var _ = Console.ReadLine().Split();
                var h = int.Parse(_[0]);
                var w = int.Parse(_[1]);
                s[i] = Tuple.Create(i,h,w);
            }
            
            var o = s.OrderByDescending(x => x.Item2).ThenBy(x => x.Item3).ToArray();
            foreach(var t in o){
                if(t.Item1 == 0){
                    Console.WriteLine("A");
                }else if(t.Item1 == 1){
                    Console.WriteLine("B");
                }else{
                    Console.WriteLine("C");
                }
            }
        }
    }
}
