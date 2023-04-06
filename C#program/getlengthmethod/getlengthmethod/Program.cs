using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getlengthmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 3,7,9,7,2,1,9,3 };
            int l = num.GetLength(0);
            Console.WriteLine("length" + l);
            Console.ReadKey();
        }
    }
    }

