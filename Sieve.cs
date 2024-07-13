using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Sieve
    {//
        public static int[] arr = new int[1000];
        public void isprime()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1;
            }
            arr[0] = 0; arr[1] = 0;
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    for (int j = i * i; j < arr.Length; j += i)
                    {
                        arr[j] = 0;
                    }
                }
            }
        }
    }
}
