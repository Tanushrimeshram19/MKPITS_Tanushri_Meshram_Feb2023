﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0 || age >= 100)
                {
                    throw new Exception("Enter the proper age");
                }
                else
                {
                    Console.WriteLine("your age is" + age);
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}

   
