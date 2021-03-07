using System;

namespace _1342
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Lcm(47, 43);
            var m = (19 * (n / 47)) + (28 * (n / 43));
            var l = n * 27;

            var s = Gcd(m, l);
            Console.WriteLine(m / s);
        }

        static long Lcm(long m, long n){
        	return (m * n) / Gcd(m, n);
        }

        static long Gcd(long m, long n)
        {
	        while (m % n != 0){
        		var temp = n;
		        n = m % n;
		        m = temp;
	        }
        	return n;
        }        
    }
}
