using System;

namespace A_VeryVeryPrimitiveGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int c = int.Parse(line[2]);

            Console.WriteLine(Winner(a,b,c));
        }

        static string Winner(int a, int b, int c){
            if(c == 0){
                while(true){
                    a--;
                    b--;
                    if(a <= 0) return "Aoki";
                    if(b <= 0) return "Takahashi";
                }
            }
            while(true){
                a--;
                b--;
                if(b <= 0) return "Takahashi";
                if(a <= 0) return "Aoki";
            }
        }
    }
}
