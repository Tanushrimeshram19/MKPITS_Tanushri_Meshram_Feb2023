namespace studentInfoProgram
{
    class student
    {
        static void Main()
        {
            int rollno, age, mobileno;
            string name, course;
            Console.WriteLine("enter roll no");
            Console.WriteLine("enter the age");
            Console.WriteLine("enter the mobile no");
            Console.WriteLine("enter name");
            Console.WriteLine("enter course");
            rollno = Convert.ToInt32(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());
            mobileno = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            course=Console.ReadLine();
            Console.WriteLine(rollno);
            Console.WriteLine(age);
            Console.WriteLine(mobileno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.ReadKey();
        }
        
        }
    }

