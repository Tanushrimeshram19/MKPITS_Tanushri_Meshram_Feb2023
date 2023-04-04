using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter char");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("char is vowel");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("char is consonant");
            }
            else
            {
                Console.WriteLine("it is not character");
            }
            Console.ReadLine();

        }
    }
}
