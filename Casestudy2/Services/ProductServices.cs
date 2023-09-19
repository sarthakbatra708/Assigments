using CaseStudy2.Models;
using CaseStudy2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy2.Services
{
    public class ProductService:IProductService
    {
        IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }
        public Product Create(Product product)
        {
            return _repository.Create(product);
        }
        public void Edit(Product product)
        {
            _repository.Edit(product);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }
        public List<Product> GetProductsByCategory(string category)
        {
            List<Product> proList = _repository.GetProducts();
            return proList.Where(p => p.Category.ToLower() == category.ToLower()).ToList();
        }
        public List<Product> GetOutOfStockProducts()
        {
            List<Product> proList = _repository.GetProducts();
            return proList.Where(p => p.Quantity==0).ToList();
            /*IEnumerable<Product> proList = _repository.GetProducts();
            List<Product> outofstockproducts = new List<Product>();
            foreach(Product p in proList)
            {
                if (p.Quantity == 0)
                {
                    outofstockproducts.Add(p);
                }
            }
            return outofstockproducts;*/
        }
        public List<Product> GetProductsInRangeOfPrice(double start, double end)
        {
            List<Product> proList = _repository.GetProducts();
            return proList.Where(p => p.UnitPrice>=start && p.UnitPrice <= end).ToList();
            /*IEnumerable<Product> proList = _repository.GetProducts();
            List<Product> productsinrange = new List<Product>();
            foreach (Product p in proList)
            {
                if (p.UnitPrice>=start && p.UnitPrice<=end)
                {
                    productsinrange.Add(p);
                }
            }
            return productsinrange;*/
        }
        public List<string> GetCategories()
        {
            List<string> categories= _repository.GetProducts().Select(x => x.Category).Distinct().ToList();
            return categories;
        }
        
    }
}
