using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarcicalbank
{
    class account
    {
        public int actno;
        public int bal = 1000;
        public void deposit(int amt)
        {
            Console.WriteLine("this is deposit method of account class");
        }
    }
    class saving : account
    {
        public void deposit(int amt)
        {
            int intrest = 500;
            bal = bal + amt + intrest;
            Console.WriteLine("ammount deposited with intrest bal is" + bal);
        }
    }
    class current : account
    {
        public void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("ammount deposited without intrest bal is" + bal);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            saving s = new saving();
            s.actno = 111;
            s.deposit(1000);

            current c = new current();
            c.actno = 123;
            c.deposit(1000);
            Console.ReadLine();
        }
    }
}


