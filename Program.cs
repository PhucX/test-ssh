using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using bai1;

namespace bai1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            Sieve sieve = new Sieve();
            sieve.isprime();
            int[] array = Sieve.arr;
            
            for (int i = 0; i < a; i++)
            {
                if (array[i] == 1)
                {
                    Console.WriteLine(i + " ");
                }
            }
            
            Console.ReadKey();
        }
    }
}
