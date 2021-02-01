using System;

namespace ABC190
{
    class B_Magic3
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int s = int.Parse(line[1]);
            int d = int.Parse(line[2]);

            Console.WriteLine(Result(n, s ,d));
        }

        static string Result(int n, int s, int d){
            for(int i=0; i<n; i++){
                string[] xy = Console.ReadLine().Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);
                if(x < s && y > d) return "Yes";
            }
            return "No";
        }
    }
}
