using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarcial2
{
  public class person
    {
        string name;
        string address;
        public void getpersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersonData()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
        }
    }
    public class student : person
    {
        int rno;
        int marks;
        public void getstudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentData()
        {
            Console.WriteLine("rno:" + rno);
            Console.WriteLine("marks:" + marks);
        }
    }
    public class employee : person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayemployeeData()
        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("designation:" + designation);
        }
    }
    class Testinheritance
    {
        public static void Main(string[] args)
        {
            student p1 = new student();
            p1.getpersonData("tanu", "nagpur");
            p1.getstudentData(345, 789);
            p1.displaypersonData();
            p1.displaystudentData();
            employee e1=new employee();
            e1.getpersonData("ravi", "nagpur");
            e1.getEmployeeData(888, "manager");
            e1.displaypersonData();
            e1.displayemployeeData();
            Console.ReadLine();
        }
    }
        }
    
