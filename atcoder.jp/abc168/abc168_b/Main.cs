using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            if(s.Length<=k){
                Console.WriteLine(s);
                return;
            }
            for(int i=0; i<k; i++){
                Console.Write(s[i]);
            }
            Console.WriteLine("...");
            return;
        }
    }
}
