    using System;
    using System.Linq;

    namespace _0211
    {
        class Program
        {
            static void Main(string[] args)
            {
                var s = new int[]{2,3,5,7,11,13};
                var t = new int[]{4,6,8,9,10,12};

                var u = new int[s.Length * t.Length];
                for(var i = 0; i < s.Length; i++){
                    for(var j = 0; j < t.Length; j++){
                        u[i * 6 + j] = s[i] * t[j];
                    }
                }

                var k = int.Parse(Console.ReadLine());
                var x = u.Count(n => n == k);
                Console.WriteLine(string.Format("{0:F19}", x * 1.0 / u.Length));
            }
        }
    }
