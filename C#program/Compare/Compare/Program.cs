using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello1";
            int res = string.Compare(s1, s2);
            if (res == 0)

                Console.WriteLine("Both string are equal");
            else if (res == 1)

                Console.WriteLine("First string are equal");
            else
                Console.WriteLine("Second string are equal");
        }
    }
}

                
    
