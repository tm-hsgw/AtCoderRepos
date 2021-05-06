using System;

namespace ARC107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(B.Solve());
        }
    }

    class B{
        public static string Solve(){
            var nk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            var cc = new long[2 * nk[0] + 1];
            for(long i=2; i<=2*nk[0]; i++){
                if(i>nk[0] + 1) cc[i] = cc[2*nk[0] + 2 - i];
                else cc[i] = i - 1;
            }

            long ans = 0;
            for(long i=2; i<=2*nk[0]; i++){
                long x = i - nk[1];
                if(x < 2 || x > 2 * nk[0]) continue;
                ans += cc[i] * cc[x];
            }

            return ans.ToString();

        }
    }
}
