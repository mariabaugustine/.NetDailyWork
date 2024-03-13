using Assignment_10_ProductManagement_WebAPI.Models;

namespace Assignment_10_ProductManagement_WebAPI.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();

        void DeleteProduct(int id);

        void UpdateProduct(int id,Product product);

        IEnumerable<Product> GetProductByAmount(double amount);
        void Delete();



    }
}
