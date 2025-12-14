using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("2303 SE Moringside Dr", "Prineville", "OR", "USA");
        Customer cust1 = new Customer("Andrew Lewis", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L1001", 899.99, 1));
        order1.AddProduct(new Product(" Mouse", "M222", 25.50, 2));


        Address addr2 = new Address("55 Elm Street", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jarod Bachelder", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Desk Lamp", "DL43", 40.00, 1));
        order2.AddProduct(new Product(" Notebook Set", "NB10", 12.75, 3));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");
        Console.WriteLine("---------------------------------");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");
        Console.WriteLine("---------------------------------");
    }
}