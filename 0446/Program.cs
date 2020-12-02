using System;

namespace _0446
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            var f = true;
            var x = 0;
            var y = 0;
            if(int.TryParse(a,out x) && int.TryParse(b,out y)){
                if((x >= 0 && x <= 12345) && (y >= 0 && y <= 12345)){
                    var s = a.Length >= 2 && a[0] == '0';
                    var t = b.Length >= 2 && b[0] == '0';
                    f = s || t ? false : true;
                }else{
                    f = false;
                }
            }else{
                f = false;
            }

            Console.WriteLine(f ? "OK" : "NG");
        }
    }
}
