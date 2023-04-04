using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter char");
            ch=Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                    Console.WriteLine("char is vowel");
                break;
                case 'e':
                    Console.WriteLine("char is vowel");
                break;
                case 'i':
                Console.WriteLine("char is vowel");
                break;
                case 'o':
                Console.WriteLine("char is vowel");
                break;
                case 'u':
                Console.WriteLine("char is vowel");
                break;
                default:
                    Console.WriteLine("char is consonant");
                break;
            }
            Console.WriteLine("this is alphabet");
            Console.ReadLine();
            
                
            }
        }
    }

