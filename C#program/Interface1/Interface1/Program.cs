using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
   
    interface interface1
    {
        void method1();
    }
    class class1 : interface1
    {
        public void method1()
        {
            Console.WriteLine("Hello from method1");
        }
    }
    class program
    {
       public static void main(string[] args)
        {
            interface1 a1 = new class1();
            a1.method1();

        }
    }
    }

