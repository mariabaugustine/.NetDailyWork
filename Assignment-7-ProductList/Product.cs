using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_ProductList
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ManufacturedBy { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public static List<Product> ProductList = new List<Product>();

        public int AddProduct()
        {
            var nameCount = ProductList.Count(name => name.ProductName.ToLower().Equals(ProductName.ToLower()));
            ProductId = ProductList.Count == 0 ? 1000 : ProductList.Max(id => id.ProductId) + 1;
            if (nameCount == 0)
            {
                ProductList.Add(new Product
                {
                    ProductName = ProductName,
                    ManufacturedBy = ManufacturedBy,
                    Description = Description,
                    ProductId = ProductId,
                    Price = Price
                });
            }
            return nameCount;

        }
        public List<Product> ViewAllProduct()
        {
            return ProductList;
        }
        public List<Product> ExpensiveProduct()
        {
            var expensiveLis = ProductList.FindAll(higher => higher.Price > 1000);
            return expensiveLis;
        }
        public List<Product> RemoveProducts()
        {
            ProductList.Clear();
            return ProductList;
        }


    }
}
