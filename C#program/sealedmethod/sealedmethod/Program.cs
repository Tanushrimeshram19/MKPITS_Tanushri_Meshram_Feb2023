using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedmethod
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class student : person
    {
        public sealed override void display()
        {
            Console.WriteLine("Hello from student");
        }
    }
        class paststudent : student
        {
        public void show()
        {


            Console.WriteLine("Hello from past");
        }


        }
    
    class program
    {
        public static void Main(string[] args)
        {
            paststudent p = new paststudent();
                p.display();
                p.show();
        }
    }
}

