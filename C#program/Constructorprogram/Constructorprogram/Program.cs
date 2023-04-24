using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name obj = new Name();
            Console.WriteLine(obj.ToString());
        }
        class Name
        {
            string name;
           public  Name()
            {
                Console.WriteLine("name");
                Console.ReadLine();
            }
        }
    }
}
