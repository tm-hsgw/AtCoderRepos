using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            var hs1 = new HashSet<int>();
            var hs2 = new HashSet<int>();
            for(int i=1; i<=n; i++){
                hs1.Add(i);
            }
            for(int i=0; i<k; i++){
                Console.ReadLine();
                string[] l = Console.ReadLine().Split(' ');
                foreach(string j in l){
                    hs2.Add(int.Parse(j));
                }
            }
            Console.WriteLine(hs1.Count - hs2.Count);
        }
    }
}
