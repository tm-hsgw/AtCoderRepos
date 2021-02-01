using System;

namespace ABC190
{
    class C_BowlsAndDishes
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);

            int[] a = new int[m + 1];
            int[] b = new int[m + 1];
            
            for(int i=0; i<m; i++){
                string[] abline = Console.ReadLine().Split(' ');
                a[i] = int.Parse(abline[0]);
                b[i] = int.Parse(abline[1]);
            }

            int k = int.Parse(Console.ReadLine());
            int kth = (int)Math.Pow(2, k);

            int[] c = new int[k];
            int[] d = new int[k];

            for(int i=0; i<k; i++){
                string[] cdline = Console.ReadLine().Split(' ');
                c[i] = int.Parse(cdline[0]);
                d[i] = int.Parse(cdline[1]);
            }

            int ans = 0;

            for(int i=0; i<kth; i++){
                bool[] dishes = new bool[n + 1];
                int res = 0;

                for(int j=0; j<k; j++){
                    int cont = i;
                    for(int dig=0; dig<j; dig++) cont = cont/2;
                    int didx = cont % 2 == 0 ? c[j] : d[j];
                    dishes[didx] = true;
                }

                for(int j=0; j<=m; j++){
                    if(dishes[a[j]] && dishes[b[j]]) res++;
                }

                ans = res > ans ? res : ans;
            }

            Console.WriteLine(ans);

            // Console.WriteLine(Result(n, s ,d));
        }
    }
}
