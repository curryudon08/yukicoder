    using System;
    using System.Linq;

    namespace _0063
    {
        class Program
        {
            static void Main(string[] args)
            {
                var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
                var l = s[0];
                var k = s[1];

                var i = 0;
                while(true){
                    if(l - (k * 2) > 0){
                        l -= k * 2;
                        i += 1;
                    }else{
                        break;
                    }
                }

                Console.WriteLine(k * i);
            }
        }
    }
