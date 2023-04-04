using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class age
    {
        static void Main()
        {
            int age;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("enter the age");

            }
            else
            {
                Console.WriteLine("eligible to vote");
                Console.ReadLine();
            }
        }
    }

    }
