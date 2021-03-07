using System;
using System.Linq;

namespace _9014
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(',').Select(i => int.Parse(i)).Sum();

            Console.WriteLine(string.Format("合計点:{0}",s));
            Console.WriteLine(string.Format("平均点:{0:F1}",s / 3.0));
        }
    }
}
