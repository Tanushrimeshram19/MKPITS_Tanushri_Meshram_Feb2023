namespace AreaProgram
{
    class Area
    {
        static void Main()
        {
            int length, breadth, area;
            Console.WriteLine("enter the length");
            Console.WriteLine("enter the breadth");
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("area of a rectangle is" + area);
            Console.ReadKey();
        }
        }
    }

