using System;

namespace ABC200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.Solve());
        }
    }

    static class A{
        public static string Solve(){
            int n = int.Parse(Console.ReadLine());
            return Math.Ceiling(n / 100d).ToString();
        }
    }
}