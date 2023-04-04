using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldandmethodparameter
{
    class student
    {
        int rno;
        string name;
        public void getdata(int r, string n)
        {
            rno = r;
            name = n;
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
            stud1.getdata(199, "tanu");
            stud1.displaydata();
            Console.ReadLine();
        }
    }
}
    
