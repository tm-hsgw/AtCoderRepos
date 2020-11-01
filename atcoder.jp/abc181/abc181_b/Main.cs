using System;

namespace B_TrapezoidSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long a = 0;
            for(int i=0; i<n; i++){
                a += TrapezoidSum();
            }
            Console.WriteLine(a);
        }

        static long TrapezoidSum(){
            var line = Console.ReadLine().Split(' ');
            long a = long.Parse(line[0]);
            long l = long.Parse(line[1]);
            return (long)(0.5 * (l - a + 1) * (a + l));
        }
    }
}
