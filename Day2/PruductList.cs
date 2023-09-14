using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductsList = new List<Product>();
            Console.WriteLine("Enter Five Product Details:");
            int ProductId,quantity;
            string ProductName;
            double unitPrice;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Product {0} Details:", i+1);
                Console.Write("Product ID:");
                try
                {
                    ProductId = int.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("OnlyInteger value",ex);
                    Console.Write("Product ID:");
                    ProductId = int.Parse(Console.ReadLine());
                }
                try
                {
                    Console.Write("Product Name:");
                    ProductName = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Only enter String value", ex);
                    Console.Write("Product Name:");
                    ProductName = Console.ReadLine();
                }
                try
                {
                    Console.Write("Unit Price:");
                    unitPrice = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Only enter Integer/Double value", ex);
                    Console.Write("Unit Price:");
                    unitPrice = double.Parse(Console.ReadLine());
                }
                try
                {
                    Console.Write("Quantity:");
                    quantity = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Only enter Integer value");
                    Console.Write("Quantity:");
                    quantity = int.Parse(Console.ReadLine());
                }
                ProductsList.Add(new Product() { Product_Id = ProductId, Product_Name = ProductName, UnitPrice = unitPrice, Quantity = quantity });

            }
            Console.WriteLine("Displaying All Products in the Product List");
            foreach(Product prod in ProductsList)
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine("Enter the ProductName of which you want to remove");
            string pname = Console.ReadLine();
            bool flag = false;
            foreach(Product p in ProductsList)
            {
                if(p.ProductName == pname)
                {
                    flag = true;
                    ProductsList.Remove(p);
                    Console.WriteLine("Successfully Deleted the product ,Remaining products are:");
                    foreach(Product prod in ProductsList)
                    {
                        Console.WriteLine(prod);
                    }
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Product with that name is not present!!");
            }

            Console.ReadLine();

        }
        class Product
        {
            public int Product_Id { get; set; }
            public string Product_Name { get; set; }
            public double UnitPrice { get; set; }
            public int Quantity { get; set; }
            public override string ToString()
            {
                string str = string.Format("Product Id: {0}, Product Name : {1}, Unit Price : {2}, Quantity : {3}", Product_Id, Product_Name, UnitPrice, Quantity);
                return str;
            }
        }
    }
}
