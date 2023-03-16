namespace AddProgram
{ 

    
   class Addition
{
    static void Main()
    {
        int num1, num2, add;
        Console.WriteLine("please enter num1");
        Console.WriteLine("please enetr num2");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        add = num1 + num2;
        Console.WriteLine("addition of a num is" + add);
        Console.ReadKey();
}
}
}
