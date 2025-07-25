using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Paddle", "0001", 129.99m, 1);
        Product product2 = new Product("Ball", "0002", 2.99m, 3);
        Product product3 = new Product("Net", "0003", 159.99m, 1);
        Product product4 = new Product("Grip", "0004", 9.99m, 1);
        Product product5 = new Product("Shoes", "0005", 99.99m, 1);
        Address jamesAddress = new Address("4687 Cliffside Drive", "Riverside", "CA", "USA");
        Customer James = new Customer("James Inskeep", jamesAddress);
        Address aliciaAddress = new Address("3210 Leland Street", "San Pedro", "CA", "USA");
        Customer Alicia = new Customer("Alicia Inskeep", aliciaAddress);
        List<Product> order1Products = new List<Product> { product1, product5, product4 };
        List<Product> order2Products = new List<Product> { product1, product2, product3 };
        Order order1 = new Order(order1Products, James);
        Order order2 = new Order(order2Products, Alicia);

        Console.Clear();

        Console.WriteLine("Order1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("Order1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice:F2}");
        Console.WriteLine();

        Console.WriteLine("Order2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("Order2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice:F2}");

        
        
    }
}