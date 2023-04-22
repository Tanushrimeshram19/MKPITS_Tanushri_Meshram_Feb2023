using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding
{
    class Account
    {
        public int bal = 1000;
        public virtual void deposit(int amt)
        {
            Console.WriteLine("deposit method of account class");
        }
    }
    class saving : Account
    {
        int intrest =500;
        public override void deposit (int amt)
        {
            bal = bal + amt + intrest;
            Console.WriteLine("deposit bal is" + bal);
        }
        
    }
    class program
    {
        public static void main(string[] args)
        {
            saving s=new saving();
            s.deposit(200);
        }
    }
}
