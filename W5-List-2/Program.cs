class Program
{
    static void Main()
    {
        Console.WriteLine("Kahve menümüzü oluşturmak için tercihlerinize ihtiyacımız var!");
        Console.WriteLine("Lütfen tercih ettiğiniz kahve için giriş yapınız.");
        Console.Write("Kahve1:");
        string coffee1 = Console.ReadLine();
        Console.Write("Kahve2:");
        string coffee2 = Console.ReadLine();
        Console.Write("Kahve3:");
        string coffee3 = Console.ReadLine();
        Console.Write("Kahve4:");
        string coffee4 = Console.ReadLine();
        Console.Write("Kahve5:");
        string coffee5 = Console.ReadLine();

        List<string> list = new List<string>();
        list.Add(coffee1);
        list.Add(coffee2);
        list.Add(coffee3);
        list.Add(coffee4);
        list.Add(coffee5);

        Console.WriteLine("Girilen Kahve İsimleri:");

        int i = 1;
        foreach (string menu in list)
        {
            Console.WriteLine($"{i} - {menu}");
            i++;
        }
    }
}
