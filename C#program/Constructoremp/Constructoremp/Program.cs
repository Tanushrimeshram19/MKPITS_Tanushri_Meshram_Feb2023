using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructoremp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj .age);
            Console.WriteLine(obj.id)a;

        }
       public class employee
        {
            public int id; 
          public  int age;
           public string name;
            public employee()
            {
                Console.WriteLine("name");
                Console.WriteLine("id");
                Console.WriteLine("age");
                Console.ReadKey();
            }


        }
    }
}
