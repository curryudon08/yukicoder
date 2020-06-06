using System;
using System.Linq;
using System.Collections.Generic;

namespace _0032
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new int[4];
            coins[0] = 0;
            foreach(var i in Enumerable.Range(1,3)){
                coins[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(coins);
            
            var changes = new int[3]{25,4,10};
            foreach(var i in Enumerable.Range(0,3)){
                while(true){
                    if(coins[i] - changes[i] >= 0){
                        coins[i] -= changes[i];
                        coins[i+1] += 1;
                    }else{
                        break;
                    }
                }
            }

            Console.WriteLine(coins[0] + coins[1] + coins[2]);
        }
    }
}
