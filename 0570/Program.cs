using System;
using System.Linq;

namespace _0570
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new Tuple<char,int>[3];
            h[0] = Tuple.Create('A', int.Parse(Console.ReadLine()));
            h[1] = Tuple.Create('B', int.Parse(Console.ReadLine()));
            h[2] = Tuple.Create('C', int.Parse(Console.ReadLine()));

            foreach(var t in h.OrderByDescending(x => x.Item2)){
                Console.WriteLine(t.Item1);
            }
        }
    }
}
