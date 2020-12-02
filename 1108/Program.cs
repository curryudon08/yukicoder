using System;
using System.Linq;

namespace _1108
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var h = int.Parse(_[1]);
            var t = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            for(var i = 0; i < n; i++){
                t[i] = t[i] + h;
            }

            Console.WriteLine(string.Join(" ", t.Select(x => x.ToString())));
        }
    }
}
