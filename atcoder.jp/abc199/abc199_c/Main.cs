using System;
using System.Linq;

namespace ABC199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(C.Solve());
        }
    }

    class A{
        public static string Solve(){
            var l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            return l[0] * l[0] + l[1] * l[1] < l[2] * l[2] ? "Yes" : "No";
        }
    }

    class B{
        public static string Solve(){
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            return Math.Max(b.Min() - a.Max() + 1, 0).ToString();
        }
    }

    class C{
        public static string Solve(){
            int n = int.Parse(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            int q = int.Parse(Console.ReadLine());

            int[] sif = new int[n];
            int[] sil = new int[n];
            for(int i=0; i<n; i++){
                sif[i] = i;
                sil[i] = n + i;
            }

            for(int i=0; i<q; i++){
                int[] query = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if(query[0] == 1){
                    int a = query[1] - 1;
                    int b = query[2] - 1;
                    if(a < n && b < n) (sif[a], sif[b]) = (sif[b], sif[a]);
                    if(a < n && b >= n) (sif[a], sil[b - n]) = (sil[b - n], sif[a]);
                    if(a >= n && b < n) (sil[a - n], sif[b]) = (sif[b], sil[a - n]);
                    if(a >= n && b >= n) (sil[a - n], sil[b - n]) = (sil[b - n], sil[a - n]);
                }
                if(query[0] == 2){
                    (sif, sil) = (sil, sif);
                }
            }

            char[] ans = new char[2 * n];
            for(int i=0; i<n; i++){
                ans[i] = s[sif[i]];
                ans[n + i] = s[sil[i]];
            }

            return new string(ans);
        }
    }
}