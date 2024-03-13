using Assignment_10_ProductManagement_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_10_ProductManagement_WebAPI.Services
{
    public class ProductService:IProductService
    {
     static List<Product> productList = new List<Product>();

        public void AddProduct(Product product)
        {
            product.ProductId=productList.Count==0?1:productList.Max(id => id.ProductId)+1;
            productList.Add(product);
        }
        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            var findItem = productList.Find(f_id => f_id.ProductId == id);
            if (findItem != null)
            {
                productList.Remove(findItem);
            }
           
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productList;

        }

        public void UpdateProduct(int id, Product product)
        {
            var updateId = productList.Find(data=>data.ProductId == id) ;
            updateId.ProductName = product.ProductName;
            updateId.ProductDescription = product.ProductDescription;
            updateId.ProductAmount = product.ProductAmount;
        }
        public IEnumerable<Product> GetProductByAmount(double amount)
        {
            var findList = productList.FindAll(value => value.ProductAmount > amount);
            return findList;
        }

        public void Delete()
        {
            if(productList != null)
            {
               productList.Clear();
            }
        }
    }
}
