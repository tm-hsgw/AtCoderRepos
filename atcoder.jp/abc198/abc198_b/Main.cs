using System;

namespace ABC198
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(B.Solve());
        }
    }

    // static class A{
    //     public static string Solve(){
    //         int n = int.Parse(Console.ReadLine());
    //         return (n - 1).ToString();
    //     }
    // }

    static class B{
        public static string Solve(){
            string n = Console.ReadLine().TrimEnd('0');
            while(n.Length > 1){
                if(n[0] != n[n.Length - 1]) return "No";
                if(n.Length <= 2) break;
                n = n.Substring(1, n.Length - 2);
            }
            return "Yes";
        }
    }
}