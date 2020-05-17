using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            double a = double.Parse(line[0]);
            double b = double.Parse(line[1]);
            double h = double.Parse(line[2]);
            double m = double.Parse(line[3]);

            double ax = a*Math.Cos(((h/12) + (m/60/12))*2*Math.PI);
            double ay = a*Math.Sin(((h/12) + (m/60/12))*2*Math.PI);
            double bx = b*Math.Cos(m/60*2*Math.PI);
            double by = b*Math.Sin(m/60*2*Math.PI);

            double ex = (ax - bx) * (ax - bx);
            double ey = (ay - by) * (ay - by);
            double d = Math.Sqrt(ex + ey);
            Console.WriteLine(d);
        }
    }
}
