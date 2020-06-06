using System;
using System.Linq;
using System.Collections.Generic;

namespace _0289
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();

            var n = new List<int>();
            foreach(var c in s.ToArray()){
                var o = 0;
                if(int.TryParse(c.ToString(),out o)){
                    n.Add(o);
                }
            }

            Console.WriteLine(n.Count > 0 ? n.Sum() : 0);
        }
    }
}
