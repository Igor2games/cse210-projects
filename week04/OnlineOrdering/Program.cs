using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "NT", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Product product11 = new Product("Duff Beer pack", 1001, 12.50m, 6);
        Product product12 = new Product("DvD collection", 2507, 50m, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product11);
        order1.AddProduct(product12);

        Console.Clear();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        // Order 2
        Address address2 = new Address("221B Baker Street", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Sherlock Holmes", address2);
        Product product21 = new Product("Donut Box (12pcs)", 1342, 4.00m, 1);
        Product product22 = new Product("Magnifying Glass", 2001, 15.75m, 1);
        Product product23 = new Product("Detective Hat", 2005, 25.00m, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(product21);
        order2.AddProduct(product22);
        order2.AddProduct(product23);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
    }
}