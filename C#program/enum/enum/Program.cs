using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    namespace enumeration3
    {


        enum Colors
        {
          purple,
          white,
          black,
        }

        class Program
        {
            static void Main(string[] args)
            {

                Colors favoriteColor = Colors.black;

                Console.WriteLine("My favorite color is " + favoriteColor);
                Console.ReadLine();
            }
        }
    }
}



        