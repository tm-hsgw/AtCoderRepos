using System;

namespace ABC199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(A.Solve());
        }
    }

    class A{
        public static string Solve(){
            var l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            return l[0] * l[0] + l[1] * l[1] < l[2] * l[2] ? "Yes" : "No";
        }
    }
}
