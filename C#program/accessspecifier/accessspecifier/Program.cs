using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessspecifier
{
    class person
    {
        public string name;
    }
    class employee : person
    {
        public int age;
    }
    class program
    {
        static void Main(string[] args)
        {
            employee e=new employee();
            e.age = 25;
            e.name = "rajesh";
            Console.WriteLine("age"+e.age);
            Console.WriteLine("name"+e.name);
            Console.ReadLine();
        }
    }
    }

