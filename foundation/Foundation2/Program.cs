using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("660 Haleola st", "Hilo", "HI", "USA");
        Address address2 = new Address("62-1330 Anecona", "Kamuela", "HI", "USA");

        Customer customer1 = new Customer("Sasaki Tom", address1);
        Customer customer2 = new Customer("Kamehameha", address2);

        Product product1 = new Product("Poi", "P001", 999.99m, 1);
        Product product2 = new Product("Poke", "P002", 19.99m, 2);
        Product product3 = new Product("Limu", "P003", 49.99m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}
