class subtraction
{

    static void Main()
    {
        int num1, num2, sub;
        Console.WriteLine("please enter num1");
        Console.WriteLine("please enter num2");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        sub = num1 - num2;
        Console.WriteLine("subtraction of a num is" + sub);
        Console.Read();
    }
}