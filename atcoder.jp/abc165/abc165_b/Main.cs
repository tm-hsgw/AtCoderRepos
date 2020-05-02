using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            int y = 1;
            double m = 100d;
            while(true){
                m += Math.Floor(m*0.01);
                if(x<=m){
                    Console.WriteLine(y);
                    return;
                }
                y++;
            }
        }
    }
}
