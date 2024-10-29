class Program
{
    static void Main()
    {


        List<string> coffees = new List<string>();

        Console.WriteLine("5 Adet Kahve İsmi Giriniz: ");

        int coffeeCounter = 1;
        for (int i = 0; i < 5; i++)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Kahve {coffeeCounter}: ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string coffee = Console.ReadLine();

            coffees.Add(coffee);
            coffeeCounter++;
        }


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Girilen Kahve İsimleri: ");

        foreach (var coffee in coffees)
        {
            Console.WriteLine(coffee);
        }




        Console.ReadKey();


    }
}
