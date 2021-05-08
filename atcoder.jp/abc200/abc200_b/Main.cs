using System;

namespace ABC200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(B.Solve());
        }
    }

    // static class A{
    //     public static string Solve(){
    //         int n = int.Parse(Console.ReadLine());
    //         return Math.Ceiling(n / 100d).ToString();
    //     }
    // }

    static class B{
        public static string Solve(){
            var nk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nk[0];
            long k = nk[1];

            for(int i=0; i<k; i++){
                if(n % 200 == 0) n /= 200;
                else n = long.Parse(n.ToString() + "200");
            }

            return n.ToString();
        }
    }
}