using System;

namespace _0089
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = int.Parse(Console.ReadLine());
            
            var _ = Console.ReadLine().Split();
            var rin = int.Parse(_[0]);
            var rout = int.Parse(_[1]);

            var s = (Math.PI * Math.PI / 4) * (rin + rout) * (rout - rin) * (rout - rin);
            Console.WriteLine(string.Format("{0:F5}",s * c));
        }
    }
}
