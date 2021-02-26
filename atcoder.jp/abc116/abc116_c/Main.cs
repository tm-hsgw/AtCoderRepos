using System;
using System.Linq;

namespace abc116_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            h.Add(0);
            
            int ans = 0;
            while(true){
                int l = -1;
                for(int j=0; j<n; j++){
                    if(h[j] != 0){
                        l = j;
                        break;
                    }
                }
                
                if(l < 0) break;
                
                int r = 0;
                for(int j=l; j<=n; j++){
                    if(h[j] == 0){
                        r = j;
                        break;
                    }
                }

                if(r <= l) break;

                for(int j=l; j<r; j++) h[j]--;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
