using System;
using System.Numerics;

public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product newProduct)
        {
            _products.Add(newProduct);
        }

        public double GetTotalPrice()
        {
            double price = 0;
            double total = 0;
            foreach (Product product in _products)
            {
                price = price + product.GetCost();
            }

            if (_customer.IsInUS() == true)
            {
                total = 5 + price;
                return total;
            }
            else
            {
                total = 35 + price;
                return total;
            }
        }

        public void DisplayPackingLabel()
        {
            Console.WriteLine("Packing Label");
            Console.WriteLine("==============================");
            foreach (Product product in _products)
            {
                Console.WriteLine(product.GetProductDetails());
            }
            Console.WriteLine();
        }

        public void DisplayShippingLabel()
        {
            Console.WriteLine("Shipping Label");
            Console.WriteLine("==============================");
            Console.WriteLine(_customer.GetCustomerDetails());
            Console.WriteLine();
        }
        
        public void DisplayOrderDetails(string orderName)
        {
            Console.WriteLine($"{orderName} Total Cost: ${GetTotalPrice()}");
            DisplayPackingLabel();
            DisplayShippingLabel();
        }
    }