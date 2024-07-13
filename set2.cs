using System;
using bai1;

namespace set2
{
    class set2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //dc7477 1221435
            Program basic = new Program();
            int[] XXX = Program.arr;
            basic.Sieve();

            for (int i = 0; i <= n; i++)
            {
                if (XXX[i] == 1) Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}