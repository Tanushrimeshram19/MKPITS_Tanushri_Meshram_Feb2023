class multiplication
{
    static void Main()
    {
        int num1, num2, multiply;
        Console.WriteLine("please enter the num1");
        Console.WriteLine("please enter the num2");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        multiply = num1 * num2;
        Console.WriteLine("multiplication of a num is" + multiply);
        Console.Read();
    }
}
