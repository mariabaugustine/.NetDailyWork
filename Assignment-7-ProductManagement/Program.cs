namespace Assignment_7_ProductManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ProductValidation productValidation = new ProductValidation();
            int choice = 1;
            Console.WriteLine("...........................PRODUCT MANAGEMENT............................");
            do
            {
                try
                {

                    Console.WriteLine("Enter the choice:\n1.Add Product\n2.View all Product\n3.View all product with price>1000\n4.Remove all Product\n5.Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                GetDetails();
                                productValidation.validation(product);
                                var count = product.AddProduct();
                                if (count > 0)
                                    Console.WriteLine("Name already exist");

                            }
                            catch (PValidation ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 2:
                            var viewAll = product.ViewAllProduct();
                            if (viewAll.Count == 0)
                            {
                                Console.WriteLine("Product list is empty");

                            }
                            else
                            {
                                foreach (Product product1 in viewAll)
                                {
                                    Console.WriteLine($"Product Id:{product1.ProductId}\tProduct Name:{product1.ProductName}\tManufacturedBy;{product1.ManufacturedBy}\tDescription:{product1.Description}\tPrice:{product1.Price}");
                                }
                            }
                            break;


                        case 3:
                            var expensive = product.ExpensiveProduct();
                            if (expensive.Count == 0)
                            {
                                Console.WriteLine("No Record Found");
                            }
                            else
                            {
                                foreach (Product product2 in expensive)
                                {
                                    Console.WriteLine($"Product Id:{product2.ProductId}\tProduct Name:{product2.ProductName}\tManufacturedBy;{product2.ManufacturedBy}\tDescription:{product2.Description}\tPrice:{product2.Price}");
                                }
                            }
                            break;
                        case 4:
                            var productList = product.RemoveProducts();
                            if (productList.Count == 0)
                            {
                                Console.WriteLine("Productlist is empty");
                            }
                            break;
                        case 5: break;

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (choice != 5);
            void GetDetails()
            {
                Console.WriteLine("Enter the product name:");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Description");
                product.Description = Console.ReadLine();
                Console.WriteLine("Enter the manufactured by");
                product.ManufacturedBy = Console.ReadLine();
                Console.WriteLine("Enter the price");
                product.Price = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}