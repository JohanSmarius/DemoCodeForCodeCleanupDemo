using System;
using Domain;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SomeNameSpace;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var customer = new Customer();
        customer.Id = 1;
        customer.Name = "John Doe";
        customer.Email = "john.doe@somewhere.com";
        
        ShoppingCartService shoppingCartService = new ShoppingCartService(customer);

        List<Product> products = new List<Product>();
        products.Add(new Product { Id = 1, Name = "Product 1", Price = 30.00m });
        products.Add(new Product { Id = 2, Name = "Product 2", Price = 45.00m });

        foreach (var product in products)
        {
            int randomQuantity = new Random().Next(1, 5);
            shoppingCartService.AddToBasket(product, randomQuantity);
        }

        var totalMessage = string.Format("Total price in shopping cart: {0:C2}", shoppingCartService.TotalPrice);

        Console.WriteLine(totalMessage);

    }
}