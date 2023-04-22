using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism2
{
    internal class Program
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
            int intrest = 500;
            public override void deposit(int amt)
            {
                bal = bal + amt + intrest;
                Console.WriteLine("deposit bal is" + bal);
            }

        }
    
        class current : Account
        {
            public override void deposit(int amt)

            {
                bal = bal + amt;
                Console.WriteLine("deposited with intrest,bal is" + bal);
            }
        }
        class program
        {
            public static void Main(string[] args)
            {
                int ammount;
                Console.WriteLine("enter the ammount");
                ammount = Convert.ToInt32(Console.ReadLine());
                Account act = null;
                string Acttype;
                Console.WriteLine("enter account type saving or current");
                Acttype = Console.ReadLine();
                if (Acttype == "saving")
                {
                    act = new saving();
                }
                else if (Acttype == "current")
                {
                    act = new current();

                }
                act.deposit(ammount);
            }
        }
    }
}


