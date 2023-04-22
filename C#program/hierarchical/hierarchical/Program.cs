using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical
{
    class person
    {
        public string name;
    }
    class student : person
    {
        public int rno;
    }
    class program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 123;
            s.name = "tanu";
            Console.WriteLine("rno" + s.rno);
            Console.WriteLine("name" + s.name);
            Console.ReadLine();
        }

    }

}
