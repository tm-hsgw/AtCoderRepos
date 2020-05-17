using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            n = n % 10;
            if(n==3){
                Console.WriteLine("bon");
                return;
            }
            if(n==0 || n==1 || n==6 || n ==8){
                Console.WriteLine("pon");
                return;
            }
            Console.WriteLine("hon");
            return;
        }
    }
}
