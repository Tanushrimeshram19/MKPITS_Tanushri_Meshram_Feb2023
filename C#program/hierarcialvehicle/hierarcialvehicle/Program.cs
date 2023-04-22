using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarcialvehicle
{
    class vehicle
        {
            String name;
            String color;
            public void getPersonData(String name, String color)
            {
                this.name = name;
                this.color = color;
            }
            public void displayPersonData()
            {
                Console.WriteLine("name : " + name);
                Console.WriteLine("color : " + color);

            }
        }

        public class vehicle1 : bus
        {

           string color;
            int  price;
            public void getvehicleData(string color, int price)
            {
               
                this.color = color;
                this.price = price;
            }
            public void displayStudentData()
            {
                
                Console.WriteLine("color: " + color);
                Console.WriteLine("price : " + price);

            }
        }
        public class Employee : Person
        {
            int salary;
            String designation;
            public void getEmployeeData(int salary, String designation)
            {
                
                this.salary = salary;
                this.designation = designation;
            }
            public void displaycustomerData()
            {
               
                Console.WriteLine("price:"+price);
                Console.WriteLine("designation : " + designation);

            }
        }

        class TestInheritance
        {
            public static void Main(string[] args)
            {
                //creating object of student class
                Student p1 = new Student();//creating object of child class\
                p1.getPersonData("arifa", "nagpur");
                p1.getStudentData(111, 999);
                p1.displayPersonData();
                p1.displayStudentData();

                //creating object of employee class
                Employee e1 = new Employee();
                e1.getPersonData("monish", "nagpur");
                e1.getEmployeeData(9999, "manager");
                e1.displayPersonData();
                e1.displayEmployeeData();

            }
        }

    }
    }
}

