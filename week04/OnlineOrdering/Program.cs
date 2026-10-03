using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("64th St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Michael Jackson", address1);
        Product product1 = new Product("Laptop", 101, 800, 1);
        Product product2 = new Product("Mouse", 102, 25, 2);
        Product product3 = new Product("Keyboard", 103, 50, 1);
        List<Product> products1 = new List<Product>
        {
            product1, product2, product3
        };

        Order order1 = new Order(products1, customer1);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total cost: $" + order1.ComputeTotalCost());
        Console.WriteLine();

        Address address2 = new Address("Av. Italia 5735", "Montevideo", "Montevideo", "Uruguay");
        Customer customer2 = new Customer("Luis Suarez", address2);
        Product product4 = new Product("Headphones", 201, 60, 1);
        Product product5 = new Product("USB Cable", 202, 10, 3);
        List<Product> products2 = new List<Product>
        {
            product4, product5
        };

        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total cost: $" + order2.ComputeTotalCost());
    }
}