using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classfieldandmethods
{
  class student
    {
        int rno;
        string name;
        public void getdata()
        {
            rno = 123;
            name = "tanu";
        }
        public void displaydata()
        {
            Console.WriteLine("rno" + rno);
            Console.WriteLine("name" + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            stud1.getdata();
            stud1.displaydata();
            Console.ReadLine();
        }
    }
}
