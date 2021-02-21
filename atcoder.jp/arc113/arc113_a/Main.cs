using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program{
    static void Main(string[] args){
        Console.WriteLine(A.Solve());
    }
}

class A{
    public static string Solve(){
        long k = long.Parse(Console.ReadLine());

        long ans = 0;
        for(long a=1; a<=k; a++){
            bool bn = true;
            for(long b=a; b<=k; b++){
                bool cn = true;
                for(long c=b; c<=k; c++){
                    int p = 6;
                    int s = 1;
                    if(a == b) s++;
                    if(b == c) s++;
                    if(c == a) s++;
                    if(s == 4) s--;

                    if(a*b*c <= k){
                        cn = false;
                        for(; s>1; s--) p /= s;
                        ans += p;
                        continue;
                    }
                    break;
                }
                if(cn) break;
                bn = false;
            }
            if(bn) break;
        }
        return ans.ToString();
    }
}
