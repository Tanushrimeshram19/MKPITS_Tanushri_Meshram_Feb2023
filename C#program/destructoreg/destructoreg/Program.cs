using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructoreg
{
    internal class Program
    {
        class student
        {
            int rollno;
            string name;
            string address;
            ~student()
            {
                Console.WriteLine(" in destructor we write code to clean up operation like closing a file etc.");
            }
            public student(int rollno, string name, string address)
            {
                this.rollno = rollno;
                this.name = name;
                this.address = address;
            }
            public void display()
            {
                Console.WriteLine("rollno"+rollno);
                Console.WriteLine("name" + name);
                Console.WriteLine("adress" + address);
            }
            }
        class program
        {
            static void Main(string[] args)
            {
                student stud = new student(345, "tanu", "nagpur");
                stud.display();
                Console.ReadLine();

            }
        }


        }
    }

