using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringequal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2= "hello";
            string s3 = "bye";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
        }
    }
}
