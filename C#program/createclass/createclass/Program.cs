﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createclass
{
  class student
    {
        public int rno;
        public string name;
    }
    class program
    {
        static void Main(string[]args)
        {
            student stud1 = new student();
            stud1.rno = 123;
            stud1.name = "tanu";
            Console.WriteLine("rno" + stud1.rno);
            Console.WriteLine("name" + stud1.name);
            Console.ReadLine();
        }
    }
}