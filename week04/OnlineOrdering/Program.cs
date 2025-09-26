using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "NT", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Product product11 = new Product("Duff Beer pack", 1001, 12.50m, 6);
        Order order1 = new Order(customer1);
        order1.AddProduct(product11);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");
    }
}