using System.Collections.Generic;
using System;
using System.Threading.Channels;
using System.Xml.Linq;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_7_ProductList
{
    internal class Program
    {
        //enum choice { AddProduct,ViewAllProducts,View_Price,Remove}
        static void Main(string[] args)
        {
            Product product = new Product();
            int choice=0;

            ProductException productException = new ProductException();
            Console.WriteLine("PRODUCT MANAGEMENT");
            do
            {
                try
                {
                    Console.WriteLine("Enter the choice\n1.ADD PRODUCT\n2.VIEW ALL PRODUCT\n3.VIEW ALL PRODUCT PRICE > 1000\n4.REMOVE ALL PRODUCT\n5.Exit");

                    choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:

                            try
                            {
                                GetInput();
                                productException.ProducttException(product);
                                product.AddProduct();
                            }
                            catch (ProductValidation ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        case 2:
                            product.DisplayAll();

                            break;
                        case 3:
                            product.ProductWithPrice();
                            break;
                        case 4:
                            product.RemoveProducts();
                            break;
                        case 5:
                            break;


                    }

                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }

                } while (choice != 5) ;
            
             void GetInput()
            {
                Console.Write("Enter the product name:");
                product.ProductName = Console.ReadLine();
                Console.Write("Enter the manufactured by:");
                product.ManufacturedBy = Console.ReadLine();
                Console.WriteLine("Enter the description:");
                product. ManufacturedBy = Console.ReadLine();
                Console.WriteLine("Enter the price:");
                product.Price = Convert.ToInt32(Console.ReadLine());
            }









        }
    }
}