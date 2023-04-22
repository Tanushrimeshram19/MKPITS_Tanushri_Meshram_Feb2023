using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationstud
{
    internal class Program
    
        {
            class student
            {
                private int studid;
                private string studname;
                public int stud1
                {
                    get { return studid; }
                    set { studid = value; }
                }
                public string stud2
                {
                    get { return studname; }
                    set { studname = value; }
                }
            }
            class program
            {
                public static void Main(string[] args)
                {
                    student e = new student();
                    e.stud1 = 1234;
                    e.stud2 = "tanu";
                    int employeeid = e.stud1;
                    string empname = e.stud2;
                    Console.WriteLine("empolyeename:");
                    Console.WriteLine("empoyeeid:" + employeeid);
                    Console.ReadLine();
                }
            }
        }
    }




