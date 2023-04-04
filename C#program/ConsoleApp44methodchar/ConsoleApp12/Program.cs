using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    static void Main(string[] args)
    {
        int n1, n2;
        char c;
        Console.WriteLine("enter num1");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter num2");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter char");
        c = Convert.ToChar(Console.ReadLine());
        cal(n1, n2, c);
        Console.ReadKey();
    }
    static void cal(int n1, int n2, char c)
    {
        Console.WriteLine("n1" + n1);
        Console.WriteLine("n2" + n2);
        Console.WriteLine("c" + c);
    }

}
   

   
