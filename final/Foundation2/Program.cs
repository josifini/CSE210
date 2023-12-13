using System;

class Program
{
    static void Main()
    {
        var customer1 = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1200.00m, 1));
        order1.AddProduct(new Product("Mouse", 102, 25.00m, 2));

        var customer2 = new Customer("Josephine Smith", new Address("456 Bellamy St", "Toronto", "ON", "Canada"));
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", 201, 50.00m, 1));
        order2.AddProduct(new Product("Monitor", 202, 150.00m, 1));

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order.GetTotalCost():C}");
        Console.WriteLine("-------------------------------------------------");
    }
}
