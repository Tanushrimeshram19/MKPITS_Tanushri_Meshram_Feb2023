using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeename;
            int basicsallary, hra, da, totalsallary;
            long employeeno;
            Console.WriteLine("enter name");
            employeename= Console.ReadLine();
            employeeno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter basicsalary");
            basicsallary = Convert.ToInt32(Console.ReadLine());
            hra = (basicsallary * 32) / 100;
            da = (basicsallary * 45) / 100;
            totalsallary = basicsallary + hra + da;
            Console.WriteLine("name:" + employeename);
            Console.WriteLine("mobno:" + employeeno);
            Console.WriteLine("hra=" + hra);
            Console.WriteLine("da=" + da);
            Console.WriteLine("totalsallary=" + totalsallary);
            Console.ReadLine();
        }


        }
    }

