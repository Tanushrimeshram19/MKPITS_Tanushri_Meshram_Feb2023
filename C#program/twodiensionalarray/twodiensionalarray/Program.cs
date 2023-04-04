using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodiensionalarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.ReadLine();
            }
        }
    }
}
        
    

