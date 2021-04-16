using System;

namespace ABC085
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(C.Solve());
        }
    }

    class C{
        public static string Solve(){
            long[] line = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long n = line[0];
            long y = line[1];

            if(10000 * n < y) return("-1 -1 -1");
            if(y < 1000 * n) return("-1 -1 -1");

            for(long a=0; a<=n; a++){
                for(long b=0; b<=n; b++){
                    if(9000 * a + 4000 * b == y - 1000 * n){
                        long c = n - a - b;
                        if(c < 0) continue;
                        
                        string s = a.ToString();
                        s += " ";
                        s += b.ToString();
                        s += " ";
                        s += c.ToString();
                        return s;
                    }
                }
            }

            return("-1 -1 -1");
        }
    }
}
