using System;
using System.Collections.Generic;

namespace C
{
    class Collinearity
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var ls = new List<Point>();
            for(int i=0; i<n; i++){
                var line = Console.ReadLine().Split(' ');
                ls.Add(new Point(int.Parse(line[0]), int.Parse(line[1])));
            }

            for(int i=0; i<n; i++){
                for(int j=i+1; j<n; j++){
                    for(int k=j+1; k<n; k++){
                        if(IsCollinear(ls[i], ls[j], ls[k])){
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No");
        }

        static bool IsCollinear(Point a, Point b, Point c){
            int dx1 = b.X - a.X;
            int dx2 = c.X - a.X;
            int dy1 = b.Y - a.Y;
            int dy2 = c.Y - a.Y;
            return dx1 * dy2 == dx2 * dy1;

        }
    }
    struct Point{
        public int X{get;}
        public int Y{get;}

        public Point(int x, int y){
            this.X = x;
            this.Y = y;
        }
    }
}
