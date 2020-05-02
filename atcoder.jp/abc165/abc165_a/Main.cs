using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            for(int i=a; i<=b; i++){
                if(i%k==0){
                    Console.WriteLine("OK");
                    return;
                }
            }
            Console.WriteLine("NG");
        }
    }
}
