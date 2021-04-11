using System;

namespace ABC198
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
            return (n - 1).ToString();
        }
    }
}