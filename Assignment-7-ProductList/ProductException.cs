using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_7_ProductList
{
    internal class ProductException
    {
       public void ProducttException(Product product)
        {
            if(string.IsNullOrEmpty(product.ProductName))
            {
                throw new ProductValidation("Name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(product.ManufacturedBy))
            {
                throw new ProductValidation("Name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(product.ManufacturedBy))
            {
                throw new ProductValidation("Name cannot be null or empty");
            }
            if(product.Price<0)
            {
                throw new ProductValidation("Price must be greater  than zero");
            }
            if (!product.ProductName.All(char.IsLetter))
            {
                throw new ProductValidation("Name must be alphabets");
            }



        }


    }
    internal class ProductValidation:Exception
    {
      public  ProductValidation(string message):base(message) 
        {

        }
    }
}
