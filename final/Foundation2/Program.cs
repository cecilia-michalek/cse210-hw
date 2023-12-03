using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        Address customerAddress = new Address("585 N Appellation Dr", "Saratoga", "Utah", "USA");
        Address customerAddress2 = new Address("44 Birch Ln", "Canary", "WS", "Canada");

        Customer customer1 = new Customer("Carlos Smith", customerAddress);
        Customer customer2 = new Customer("Emma Johnson", customerAddress2);
        
        Product product1 = new Product("Air Fryer", 091);
        product1.SetPrice(45.00f);
        product1.SetQuantity(1);

        Product product2 = new Product("Socks", 082);
        product2.SetPrice(5.00f);
        product2.SetQuantity(3);

        Product product3 = new Product("Spatula", 390);
        product3.SetPrice(2.00f);
        product3.SetQuantity(2);

        Product product4 = new Product("Chair", 1390);
        product3.SetPrice(20.00f);
        product3.SetQuantity(4);

        Product product5 = new Product("Table", 9022);
        product3.SetPrice(200.00f);
        product3.SetQuantity(1);

        List<Product> products1 = new List<Product> {product1, product2, product3};
        Order order1 = new Order(products1, customer1);

        List<Product> products4 = new List<Product> {product4, product5};
        Order order2 = new Order(products4, customer2);

        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLable());
        Console.WriteLine(order1.GetShippingLable());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.CalcualateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine(order2.GetShippingLable());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.CalcualateTotalCost()}");
        Console.WriteLine();
        
    }
}