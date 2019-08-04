using System;

namespace C_BuildStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');

            int min = 1000000000;

            for(int i=n-1; 0<=i; i--){
                int hi = int.Parse(line[i]);
                if(hi<min) min = hi;
                if(min+2<=hi){
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
