    using System;

    namespace _0780
    {
        class Program
        {
            static void Main(string[] args)
            {
                var _ = Console.ReadLine().Split();
                var a = int.Parse(_[0]);
                var b = int.Parse(_[1]);

                if(a + 1 <= b){
                    Console.WriteLine("YES");
                    Console.WriteLine(b - (a + 1));
                }else{
                    Console.WriteLine("NO");
                    Console.WriteLine((a + 1) - b);
                }
            }
        }
    }
