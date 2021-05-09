using System;

namespace ARC118
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.Solve());
        }
    }

    static class A{
        public static string Solve(){
            var tn = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            var k = Math.Ceiling(tn[1] / (tn[0] / 100d));
            var a = Math.Floor(k * (100 + tn[0]) / 100d);

            return (a - 1).ToString();
        }
    }
}
