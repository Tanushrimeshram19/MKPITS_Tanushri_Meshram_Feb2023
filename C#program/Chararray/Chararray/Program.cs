using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chararray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "tanu meshram";
            char[] ch=s1.ToCharArray();
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }
        }
    }
}
