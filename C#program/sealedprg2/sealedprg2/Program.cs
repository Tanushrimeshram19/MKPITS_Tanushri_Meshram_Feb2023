using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedprg2
{
    sealed class student
    {
        public void showdata()
        {
            Console.WriteLine("Hello");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.showdata();
        }
    }
}
