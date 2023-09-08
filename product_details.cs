using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            float ProductId ,UnitPrice ,Quantity,Discount,Total,Discountamt,finalamt ;
            string ProductName;
            Console.WriteLine("Enter Product ID");
           
            ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            ProductName = Console.ReadLine();
            Console.WriteLine(      "Enter Unit Price");
           
            UnitPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Qty");
            
            Quantity = Convert.ToInt32(Console.ReadLine());

            if (Quantity >= 50)
            {
                Discount = 30;
                Total = UnitPrice * Quantity;
                Discountamt= ((Discount/100)*Total);
                finalamt = Total - ((Discount / 100) * Total);
               
            }
            else if(Quantity >=30 )
            {
                Discount = 20;
                Total = UnitPrice * Quantity;
                Discountamt = ((Discount / 100) * Total);
                finalamt = Total - ((Discount / 100) * Total);
            }
            else if(Quantity>=10)
            {
                Discount=10;
                Total = UnitPrice * Quantity;
                Discountamt = ((Discount / 100) * Total);
                finalamt = Total - ((Discount / 100) * Total); 
            }
            else
            {
                Total = UnitPrice * Quantity;
                Discountamt = 0;
                finalamt =Total;

            }
           
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Product Id : "+ProductId);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Unit Price : " + UnitPrice);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Total Amount : " + Total);
            Console.WriteLine("Discount Amount : " + Discountamt);
            Console.WriteLine("Final Amount : " + finalamt);
            Console.ReadLine();

        }
    }
}
