using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodreturning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            return num;
        }
       
        static void Main()
        {
            int[] arr = returnarray();
            {
                int[] num = { 1, 2, 3 };
                return num;
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }
        }
    }

