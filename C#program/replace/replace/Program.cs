using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s1 = "hello F#";
            string s2=s1.Replace('f','c');
            Console.WriteLine(s2);
        }
    }
}
