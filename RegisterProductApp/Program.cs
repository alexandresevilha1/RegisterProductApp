using RegisterProductApp.Entities;
using System.Collections.Generic;
using System.Globalization;

List<Product> List = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)?");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'c')
    {
        List.Add(new Product(name, price));
    }
    else if (ch == 'u')
    {
        Console.Write("Manufacture date: ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        List.Add(new UsedProduct(name, price, manufactureDate));
    }
    else if (ch == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        List.Add(new ImportedProduct(name, price, customsFee));
    }
}

Console.WriteLine("PRICE TAGS:");
foreach (Product product in List)
{
    Console.WriteLine(product.PriceTag());
}

