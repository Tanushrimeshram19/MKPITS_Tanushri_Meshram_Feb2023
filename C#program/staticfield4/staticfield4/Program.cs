using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace staticfield4
{
    class account
    {
        public int accno;
        public string name;
        public static int count;
        public account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count ++;
        }
        public void display()
        {
            Console.WriteLine("accno" + accno);
            Console.WriteLine("name" + name);
            
        }
        class program
        {
            public static void Main(string[] args)
            {
                account a1 = new account(123, "tanu");
                account a2 = new account(345, " manish");
               
                a1.display();
                a2.display();
                Console.WriteLine("no of object" + account.count);
                Console.ReadLine();


            }
        }
    }

}

   
