using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("enter the num");
            n1 = Convert.ToInt32(Console.ReadLine());
            int result = fact(n1);
            Console.WriteLine("fact" + result);
            Console.ReadLine();
        }
        static int fact(int num)
        {
            int fact = 1, i;
            for(i=1; i<=num; i++) 
            { 
            fact= fact*i;
            }
            return fact;
        }
        
            
            }
        }

        


