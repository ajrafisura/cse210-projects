using System;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress1 = new Address("7th Ave", "New York", "NY", "USA");
        Address customerAddress2 = new Address("Tindale St", "General Santos City", "South Cotabato", "Philippines");

        Customer customer1 = new Customer("John Smith",customerAddress1);
        Customer customer2 = new Customer("Manny Pacquiao",customerAddress2);

        Product Product1 = new Product("Eraser", "ER123", 1.68, 3);
        Product Product2 = new Product("Pencil", "PC345", 6.22, 5);
        Product Product3 = new Product("Sharpener", "SH678", 4.34, 2);
        Product Product4 = new Product("Pencil Case", "PC789", 5.75, 2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(Product1);
        order1.AddProduct(Product2);
        order1.AddProduct(Product4);
        
        order2.AddProduct(Product1);
        order2.AddProduct(Product2);
        order2.AddProduct(Product3);

        order1.DisplayOrderDetails("Order 1");
        order2.DisplayOrderDetails("Order 2");
    }
}