using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    interface IAaccount
    {
        string deposit(int amt);
    }
    abstract class account : IAaccount
    {

        public int balance = 1000;
        public abstract string deposit(int amt);
        public string showbalance()
        {
            return "bal is" + balance.ToString();
        }
    }
    class saving : account
    {
        int intrest = 500;
        public override string deposit(int amt)
        {
            balance = balance + amt + intrest;
            return "ammount deposited with intrest bal is " + balance;
        }
    }
    class current : account
    {
        public override string deposit(int amt)
        {
            balance = balance + amt;
            return "ammount deposited without intrest bal is" + balance;
        }
    }
    class program
    {
       public  static void Main(string[] args)
        {
            account act = null;
            string acttype;
            Console.WriteLine("enter the account type");
            acttype = Console.ReadLine();
            Console.WriteLine("enter to be amount");
            int ammount = Convert.ToInt32(Console.ReadLine());
            if (acttype == "saving") 
            {
                act= new saving();
            }
            if (acttype == "current") 
            {
                act =new current();
            }
            string res = act.deposit(ammount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalance());
            Console.ReadKey();
        }
    }
}

        

     

   
