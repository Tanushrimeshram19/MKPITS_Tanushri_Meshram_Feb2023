﻿using System;
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
            ushort b1;
            Console.WriteLine("enter ushort number");
            b1=Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("ushort enterd=" + b1);
            Console.ReadLine();
        }
    }
}
