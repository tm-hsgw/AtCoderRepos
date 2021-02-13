using System;

namespace ARC112
{
    class A
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++){
                var line = Console.ReadLine().Split(' ');
                int l = int.Parse(line[0]);
                int r = int.Parse(line[1]);

                if(r+1 < l*2){
                    Console.WriteLine(0);
                    continue;
                }

                int n = r - l + 1;

                var s = 0.5 * (n - l) * (2 + (n - l) - 1);

                Console.WriteLine(s);
            }
        }
    }
}

