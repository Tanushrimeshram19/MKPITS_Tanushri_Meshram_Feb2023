using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration5
{
    enum planet
    {
        Mercury,Earth,mars,jupiter,saturn,uranus
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of mercury month is" + Convert.ToInt32(planet.Mercury));
            Console.WriteLine("value of  earth is" + Convert.ToInt32(planet.Earth));
            Console.WriteLine("value of   mars is" + Convert.ToInt32(planet.mars));
            Console.WriteLine("value of  jupiter is" + Convert.ToInt32(planet.jupiter));
            Console.WriteLine("value of  saturn is" + Convert.ToInt32(planet.saturn));
            Console.WriteLine("value of  uranus is" + Convert.ToInt32(planet.uranus));
            Console.ReadLine();

        }
    }

}
    


