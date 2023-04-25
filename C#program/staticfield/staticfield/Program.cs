using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfield
{
    class account
    {
        public int accno;
        public string name;
        public static float roi = 4.5f;
        public account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("accno" + accno);
            Console.WriteLine("name" + name);
            Console.WriteLine("rate of intrest" + roi);
        }
        class program
        {
            public static void Main(string[] args)
            {
                account a1 = new account(123,"tanu");
                account a2 = new account(345, " manish");
                account.roi = 33.4f;
                a1.display();
                a2.display();
                Console.ReadLine(); 


            }
        }
    }

    }

