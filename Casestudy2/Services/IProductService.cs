using CaseStudy2.Models;

namespace CaseStudy2.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product Create(Product product);
        void Edit(Product product);
        void Delete(int id);
        Product GetProductById(int id);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsInRangeOfPrice(double start ,double end);
        List<string> GetCategories();

    }
}
