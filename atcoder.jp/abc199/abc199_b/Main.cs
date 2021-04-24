using System;
using System.Linq;

namespace ABC199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(B.Solve());
        }
    }

    class A{
        public static string Solve(){
            var l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            return l[0] * l[0] + l[1] * l[1] < l[2] * l[2] ? "Yes" : "No";
        }
    }

    class B{
        public static string Solve(){
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            return Math.Max(b.Min() - a.Max() + 1, 0).ToString();
        }
    }
}