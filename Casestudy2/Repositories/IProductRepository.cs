using CaseStudy2.Models;
namespace CaseStudy2.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product Create(Product product);
        void Edit(Product product);
        void Delete(int id);
        Product GetProductById(int id);
    }
}
