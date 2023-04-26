using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration1
{
    enum month
    {
        january,february,march,april,may,june
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("value of jan month is"+Convert.ToInt32(month.january));
            Console.WriteLine("value of feb month is" + Convert.ToInt32(month.february));
            Console.WriteLine("value of mar month is" + Convert.ToInt32(month.march));
            Console.WriteLine("value of apr month is" + Convert.ToInt32(month.april));
            Console.WriteLine("value of may month is" + Convert.ToInt32(month.may));
            Console.WriteLine("value of jun month is" + Convert.ToInt32(month.june));
            Console.ReadLine();

        }
    }

    }
    
