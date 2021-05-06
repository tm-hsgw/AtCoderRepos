using System;

namespace ABC046
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(B.Solve());
        }
    }

    class B{
        public static string Solve(){
            var nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            double a = nk[1];
            for(int i=1; i<nk[0]; i++){
                a *= nk[1] - 1;
            }
            return a.ToString();
        }
    }
}
