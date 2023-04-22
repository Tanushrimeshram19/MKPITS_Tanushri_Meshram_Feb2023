using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createbasedclass
{
    class student1
    {
        public string name;
    }
    class student2:student1
    {
        public int rollno;
    }
    class program
    {
        static void Main(string[] args)
        {
            student1 s = new student1();
            s.rollno = 1789;
            s.name = "tanushree";
            Console.WriteLine("rollno")

        }
    }


}
    }
}
