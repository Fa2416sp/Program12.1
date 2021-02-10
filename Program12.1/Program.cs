using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((i % 2 == 0) || (j % 2 == 1))
                        A[i, j] = 8;
                    else A[i, j] = 0;
                    Console.Write("{0,4} ", A[i, j]);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
