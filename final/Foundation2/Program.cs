using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        var customer1 = new Customer("John Doe", new Address("34 Guanapo St", "Bronx", "NY", "USA"));
        var customer2 = new Customer("Jane Doe", new Address("46 Random St", "St.Town", "ON", "Canada"));

       
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Phone", "GP6a", 199.99m, 3));
        order1.AddProduct(new Product("Watch", "RX1", 129.99m, 2));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Shoe", "S155", 59.99m, 2));
        order2.AddProduct(new Product("Cape", "C221", 14.99m, 1));

        
        var orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine($"Order for {order.Customer.Name} ({(order.Customer.LivesInUSA() ? "USA" : "International")})");
            Console.WriteLine($"Total Cost: ${order.TotalCost()}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
        }
    }
}
