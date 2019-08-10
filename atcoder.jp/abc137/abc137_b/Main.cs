using System;

namespace ABC_20190810_A0137_p_x_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int k = int.Parse(line[0]);
            int x = int.Parse(line[1]);

            int ans0 = x-k +1;
            int ansn = k*2 -1;
            for(int i=0; i<ansn; i++) Console.Write(ans0+i + " ");
            Console.WriteLine();
        }
    }
}
