using System;

namespace ABC198
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(C.Solve());
        }
    }

    // static class A{
    //     public static string Solve(){
    //         int n = int.Parse(Console.ReadLine());
    //         return (n - 1).ToString();
    //     }
    // }

    // static class B{
    //     public static string Solve(){
    //         string n = Console.ReadLine().TrimEnd('0');
    //         while(n.Length > 1){
    //             if(n[0] != n[n.Length - 1]) return "No";
    //             if(n.Length <= 2) break;
    //             n = n.Substring(1, n.Length - 2);
    //         }
    //         return "Yes";
    //     }
    // }

    static class C{
        public static string Solve(){
            double[] line = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double r = line[0];
            double x = line[1];
            double y = line[2];

            double distance = Math.Sqrt(x * x + y * y);
            long ans = 0;
            if(distance < r) ans++;
            while(distance > r){
                ans++;
                distance -= r;
            }
            if(distance > 1e-6) ans++;
            return ans.ToString();
        }
    }
}