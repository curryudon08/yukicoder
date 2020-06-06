using System;
using System.Linq;
using System.Text;

namespace _0292
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var s = input[0];
            var t = int.Parse(input[1]);
            var v = int.Parse(input[2]);

            if(t == v){
                Console.WriteLine(s.Remove(t, 1));
            }else{
                var output = Enumerable.Range(0, s.Length).Where(i => (i != t && i != v)).Select(i => s[i]).ToArray();
                Console.WriteLine(string.Join("",output));
            }
        }
    }
}
