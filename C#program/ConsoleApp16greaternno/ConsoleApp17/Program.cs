﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter num1");
            Console.WriteLine("enter num2");
            num1=Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else
            {
                Console.WriteLine("num 2 is smaller");
                Console.ReadLine();
            }
        }

        
        }
    }


