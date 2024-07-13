using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class Program
    {
        public static int[] arr = new int[1001];
        public void Sieve()
        {
            for(int i = 0; i < arr.Length;i++) arr[i] = 1;
            arr[0] = arr[1] = 0;

            for(int i = 2;i<=Math.Sqrt(1000);i++)
            {
                if (arr[i] == 1)
                {
                    for (int j = i * i; j <= 1000; j += i) arr[j] = 0;
                }
            }
        }

        public void IsPrime()
        {
            Sieve();
            for(int i = 0 ; i<arr.Length;i++)
            {
                if (arr[i] == 1) Console.Write(i + " ");
            }
        }
    }
}
