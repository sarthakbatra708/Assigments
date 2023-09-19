using CaseStudy2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace CaseStudy2.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
            Create(new Product { ProductId = 1, Name = "Stand", Category = "Furniture", UnitPrice = 2000, Quantity = 0, Description = "A table stand for Placing books ad other stuff" });
            Create(new Product { ProductId = 2, Name = "Protein powder", Category = "Food Supplements", UnitPrice = 3000, Quantity = 1, Description = "Absolute Nutrition Chocolate Flavour whey protein" });
            Create(new Product { ProductId = 3, Name = "Kettle", Category = "Home Appliances", UnitPrice = 1400, Quantity = 3, Description = "A mini multipurpose portable kettel to cook items" });


        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.ProductId == id);
        }

        public Product Create(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ProductId = _nextId++;
            products.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            products.RemoveAll(p => p.ProductId == id);
        }

        public void Edit(Product product)
        {
            foreach (Product p in products)
            {
                if (p.ProductId == product.ProductId)
                {
                    product.Name = p.Name;
                    product.Category = p.Category;
                    product.UnitPrice = p.UnitPrice;
                    product.Quantity = p.Quantity;
                    product.Description = p.Description;
                }
            }
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = products.FindIndex(p => p.ProductId == item.ProductId);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);

        }
        List<Product> prodList;

        public ProductRepository()
        {
            prodList = new List<Product>()
            {
                new Product(){ProductId=1,Name="Stand",Category="Furniture",UnitPrice=2000,Quantity=1,Description="A table stand for Placing books ad other stuff"},
                new Product(){ProductId=2,Name="Protein powder",Category="Food Supplements",UnitPrice=3000,Quantity=1,Description="Absolute Nutrition Chocolate Flavour whey protein"},
                new Product(){ProductId=3,Name="Kettle",Category="Home Appliances",UnitPrice=1400,Quantity=3,Description="A mini multipurpose portable kettel to cook items"}

            };
            prodList.Add(new Product() { ProductId = 4, Name = "Watch", Category = "Accessories", UnitPrice = 10000, Quantity = 0, Description = "fossil gold watch" });
        }

        public Product GetProductById(int id)
        {
            Product obj = null;
            foreach(Product p in prodList)
            {
                if(p.ProductId == id)
                {
                    obj = p ;

                }
            }
            return obj;
        }

        public List<Product> GetProducts()
        {

            return prodList;
        }
        public List<Product> Create(Product product)
        {
            List<Product> plist= prodList;
            plist.Add(product);
            //prodList.Add(new Product() { ProductId = 5, Name = "Watch2", Category = "Accessories", UnitPrice = 10000, Quantity = 0, Description = "fossil gold watch" });
            prodList = plist;
            //string s= "Product Details added";
            return prodList;
        }
        public void Edit(Product product)
        {
            foreach(Product p in prodList)
            {
                if(p.ProductId == product.ProductId)
                {
                    product.Name = p.Name;
                    product.Category = p.Category;
                    product.UnitPrice = p.UnitPrice;
                    product.Quantity = p.Quantity;
                    product.Description = p.Description;
                }
            }
        }
        public void Delete(Product product)
        {
            foreach (Product p in prodList)
            {
                if (p.ProductId == product.ProductId)
                {
                    prodList.Remove(p);
                }
            }

        }*/

    }
}
