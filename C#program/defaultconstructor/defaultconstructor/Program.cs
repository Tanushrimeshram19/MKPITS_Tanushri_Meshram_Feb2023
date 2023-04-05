using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultconstructor
{
    class student
    {
        int rno;
        string name;
        
        public student()
        {
            rno = 999;
            name = "rajesh";
        }
        public void displaydata()
        {

            Console.WriteLine("rno " + rno);
            Console.WriteLine("name " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            student stud1 = new student();

            stud1.displaydata();
            Console.ReadLine();
        }
    }
}

