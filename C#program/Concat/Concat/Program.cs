using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2="c#";
            Console.WriteLine(string.Concat(s1, s2));
            Console.ReadLine();
        }
    }
}
