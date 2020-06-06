using System;
using System.Linq;

namespace _0494
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "yukicoder".ToCharArray();
            var s = Console.ReadLine().ToArray().Where(c => c != '?').ToArray();
            var r = string.Join("",a.Except(s));
            Console.WriteLine(r);
        }
    }
}
