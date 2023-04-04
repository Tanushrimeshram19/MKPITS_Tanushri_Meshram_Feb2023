namespace hotel
{
  static void Main()
    {
        string dishname, typeofdish,additionaldish;
        int price;
        Console.WriteLine("enter the dish name");
        Console.WriteLine("enter the type of dish");
        Console.WriteLine("enter the additional dish");
        Console.WriteLine("enter the price");
        dishname = Console.ReadLine();
        typeofdish = Console.ReadLine();
        additionaldish = Console.ReadLine();
        price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(dishname);
        Console.WriteLine(typeofdish);
        Console.WriteLine(additionaldish);
        Console.WriteLine(price);
        Console.ReadKey();
        
    }
}
