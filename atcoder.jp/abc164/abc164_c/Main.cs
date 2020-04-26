using System;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new HashSet<string>();
            int a = int.Parse(Console.ReadLine());
            for(int i=0; i<a; i++){
                h.Add(Console.ReadLine());
            }
            Console.WriteLine(h.Count);
        }
    }
}
