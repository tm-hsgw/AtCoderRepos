using System;

namespace ARC081
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

            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            Array.Sort(a);
            Array.Reverse(a);
            long ans = 0;
            bool w = false;
            for(int i=1; i<n; i++){
                if(a[i - 1] == a[i]){
                    if(!w){
                        w = true;
                        ans = a[i];
                        i++;
                        continue;
                    }
                    ans *= a[i];
                    break;
                }
            }
            if(ans == 0) return "0";
            return ans.ToString();
        }
    }
}
