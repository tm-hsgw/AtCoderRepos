using System;
using System.Collections.Generic;

namespace abc131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(D.Solve());
        }
    }

    class D{
        public static string Solve(){
            int n = int.Parse(Console.ReadLine());

            var tasks = new List<long[]>(n);
            for(int i=0; i<n; i++){
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                tasks.Add(line);
            }

            tasks.Sort((x, y) => x[1].CompareTo(y[1]));

            long t = 0;

            foreach(var task in tasks){
                t += task[0];
                if(t > task[1]) return "No";
            }

            return "Yes";
        }
    }
}
