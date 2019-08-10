using System;

namespace ABC_20190810_A0137_p_x_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            int ans = a+b;
            if(ans<a-b) ans = a-b;
            if(ans<a*b) ans = a*b;

            Console.WriteLine(ans); 

        }
    }
}
