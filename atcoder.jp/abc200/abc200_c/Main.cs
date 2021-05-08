using System;

namespace ABC200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(C.Solve());
        }
    }

    // static class A{
    //     public static string Solve(){
    //         int n = int.Parse(Console.ReadLine());
    //         return Math.Ceiling(n / 100d).ToString();
    //     }
    // }

    // static class B{
    //     public static string Solve(){
    //         var nk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
    //         long n = nk[0];
    //         long k = nk[1];

    //         for(int i=0; i<k; i++){
    //             if(n % 200 == 0) n /= 200;
    //             else n = long.Parse(n.ToString() + "200");
    //         }

    //         return n.ToString();
    //     }
    // }

    static class C{
        public static string Solve(){
            long n = long.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            long[] cnt = new long[200];

            for(int i=0; i<n; i++){
                cnt[a[i] % 200]++;
            }

            long ans = 0;
            for(int i=0; i<200; i++){
                if(cnt[i] < 2) continue;
                ans += (cnt[i] * cnt[i] - cnt[i]) / 2;
            }

            return ans.ToString();
        }
    }
}