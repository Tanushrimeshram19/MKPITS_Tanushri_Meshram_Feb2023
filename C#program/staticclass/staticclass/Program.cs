using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclass
{
    public static class calculate
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }

    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("pi="+calculate.pi);
            Console.WriteLine("cube=" + calculate.cube(6));
        }
    } 
}
    
