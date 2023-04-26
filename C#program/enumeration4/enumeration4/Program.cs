using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration4
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Monday;
            Console.WriteLine("Today is " + today);
            Console.ReadLine();
        }
    }

}
   







   
