using System;
using System.Linq;
using System.Collections.Generic;

namespace codefes2017_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] d = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            long[] t = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            
            Dictionary<long, int> dDic = new Dictionary<long, int>();
            for(int i=0; i<n; i++){
                if(!dDic.TryAdd(d[i], 1)) dDic[d[i]]++;
            }
            for(int i=0; i<m; i++){
                try{
                    dDic[t[i]]--;
                    if(dDic[t[i]] < 0){
                        Console.WriteLine("NO");
                        return;    
                    }
                }
                catch{
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
