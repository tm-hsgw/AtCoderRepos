using System;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            string[] h = Console.ReadLine().Split(' ');
            var ls = new List<int>();
            var it = new List<int>();
            foreach(string st in h){
                it.Add(int.Parse(st));
                ls.Add(1);
            }

            for(int i=0; i<m; i++){
                string[] r = Console.ReadLine().Split(' ');
                int a = int.Parse(r[0]) - 1;
                int b = int.Parse(r[1]) - 1;
                if(it[a]<=it[b]) ls[a] = 0;
                if(it[b]<=it[a]) ls[b] = 0;
            }
            Console.WriteLine(ls.Sum());
        }
    }
}
