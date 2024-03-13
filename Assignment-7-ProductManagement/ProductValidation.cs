using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_ProductManagement
{
    internal class ProductValidation
    {
        public void validation(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductName))
                throw new PValidation("Name cannot be blank");
            if (!product.ProductName.All(char.IsLetter))
                throw new PValidation("Name must be alphabets");
            if (string.IsNullOrEmpty(product.ManufacturedBy))
            {
                throw new PValidation("Name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(product.ManufacturedBy))
            {
                throw new PValidation("Name cannot be null or empty");
            }
            if (product.Price < 0)
            {
                throw new PValidation("Price must be greater  than zero");
            }

        }

    }
    internal class PValidation : Exception
    {
        public PValidation(string message) : base(message)
        {

        }
    }

}

