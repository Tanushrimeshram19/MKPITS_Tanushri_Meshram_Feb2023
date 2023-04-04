using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte b1;
            Console.WriteLine("enter the byte");
            b1=Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte entered=" + b1);
            Console.ReadLine();
        }
    }
}
