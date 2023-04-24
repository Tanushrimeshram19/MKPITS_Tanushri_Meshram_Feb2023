using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soetarray2
{
    internal class Program
    {
        static void Main(string[] args)
     
            {
                int[] num = { 5,6,3,2,9,1,4 };
                Array.Sort(num);
                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine(num[i] + "\t");
                    Console.ReadLine();

                }
            }
        }
    }


    

