using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Product Ordering System ===\n");

        Address address1 = new Address("596 Freedom Blvd" , "Springfield" , "MO" , "USA");
        Customer customer1 = new Customer("Jack Smith", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("ArcticShield Thermal Parka" , "WP-48321" , 139.99 , 1));
        order1.AddProduct(new Product("MountainTrek Merino Wool Socks (3-Pack)" , "SK-55602" , 18.75 , 3));
        order1.AddProduct(new Product("FrostGuard HandWarmers" , "GL-77209" , 29.50 , 6));

        Address address2 = new Address("78621 Liberty Lane" , "Toronto" , "ON" , "CANADA");
        Customer customer2 = new Customer("Olivia Johnson", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("CanineCrunch Premium Dog Food (40 lb)" , "DG-40122" , 49.99 , 15));
        order2.AddProduct(new Product("AquaGlow LED Aquarium Starter Kit (10-gallon)" , "AQ-10054" , 79.00 , 6));
        order2.AddProduct(new Product("ReptiTherm Heat Mat (Medium)" , "RP-33012" , 27.95 , 8));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("-------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine("-------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost():F2}\n");
    }
}