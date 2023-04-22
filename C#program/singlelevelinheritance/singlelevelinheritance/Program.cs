using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelevelinheritance
{
    public class animal
    {
        public void eat()
        { Console.WriteLine("eating"); }
}
    public class dog : animal
    {
        public void bark()
        { Console.WriteLine("barking..."); 
}
    class TestInheritance2
    {
        public static void Main(string[] args)
        {
            dog d1=new dog();
            d1.eat();
            d1.bark();
                Console.ReadLine();
        }
    }
    }
}
