namespace Assignment_9_MobileManagement
{
    internal class Program
    {
        enum Operation
        {
            AddMobile=1,
            ViewAllMobile,
            SearchMobileByPrice,
            SearchMobileByMnufacturer,
            ViewByPrice,
            RemoveByPrice,
            Exit
        }
        static void Main(string[] args)
        {
            double result;
            Operation operation=0;
            Mobile mobile = new Mobile();
            MobileValidation mobileValidation = new MobileValidation();
            Console.WriteLine("************************************MOBILE MANAGEMENT************************************");
            do
            {
                try
                {
                    Console.WriteLine("\n\nEnter the choice:\n" +
                        "1.Add Mobile\n" +
                        "2.View All Mobile\n" +
                        "3.Search Price Less than  Maximum Price\n" +
                        "4.Search By Manufacturer\n" +
                        "5.View Mobiles Price Greater than Minimum and Less than Maximum \n" +
                        "6.Remove Mobiles Price Greater than Minimum Aand Less than Maximum\n" +
                        "7.Exit ");
                    operation = (Operation)Convert.ToInt32(Console.ReadLine());
                    switch (operation)
                    {
                        case Operation.AddMobile:
                            try
                            {
                                GetData();
                                mobileValidation.validation(mobile);
                                var count = mobile.AddMobile();
                                if (count > 0)
                                {
                                    Console.WriteLine("*****************MOBILE ALREADY EXISTS**********************");
                                }
                                else
                                {
                                    Console.WriteLine("****************Mobile Added succcessfully*******************");
                                }
                            }
                            catch(MobileException ex) 
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case Operation.ViewAllMobile:
                            var viewList = mobile.ViewAllMobile();
                            if (viewList.Count == 0)
                            {
                                Console.WriteLine("*************************Mobile List is Empty***********************");

                            }
                            else
                            {
                                foreach (Mobile item in viewList)
                                {
                                    Console.WriteLine($"Mobile Id:{item.MobileId}\t" +
                                        $"Name:{item.Name}\tDescription:{item.Description}\t" +
                                        $"ManufacturedBy:{item.ManufacturedBy}\t" +
                                        $"Price:{item.Price}");
                                }
                            }
                            break;
                        case Operation.SearchMobileByPrice:
                            var searchList = mobile.SearchByPrice();
                            if (searchList.Count == 0)
                            {
                                Console.WriteLine("*****************************No Record Found***************************");
                            }
                            else
                            {
                                foreach (Mobile items in searchList)
                                {
                                    Console.WriteLine($"Mobile Id:{items.MobileId}\t" +
                                        $"Name:{items.Name}\tDescription:{items.Description}\t" +
                                        $"ManufacturedBy:{items.ManufacturedBy}\t" +
                                        $"Price:{items.Price}");
                                }
                            }
                            break;
                        case Operation.SearchMobileByMnufacturer:
                            Console.WriteLine("\n\nEnter the name of manufaturer");
                            mobile.ManufacturerName = Console.ReadLine();
                            var searchByManufacturerList = mobile.SearchByManufacturer();
                            if (searchByManufacturerList.Count == 0)
                            {
                                Console.WriteLine("*************************No Record Found***********************************");
                            }
                            else
                            {
                                foreach (Mobile items in searchByManufacturerList)
                                {
                                    Console.WriteLine($"Mobile Id:{items.MobileId}\t" +
                                        $"Name:{items.Name}\tDescription:{items.Description}\t" +
                                        $"ManufacturedBy:{items.ManufacturedBy}\t" +
                                        $"Price:{items.Price}");
                                }
                            }
                            break;
                        case Operation.ViewByPrice:
                            var viewByPrice = mobile.ViewByPrice();
                            if (viewByPrice.Count == 0)
                            {
                                Console.WriteLine("***************************No Record Found***************************************");
                            }
                            else
                            {
                                foreach (Mobile items in viewByPrice)
                                {
                                    Console.WriteLine($"Mobile Id:{items.MobileId}\t" +
                                        $"Name:{items.Name}\tDescription:{items.Description}\t" +
                                        $"ManufacturedBy:{items.ManufacturedBy}\t" +
                                        $"Price:{items.Price}");
                                }
                            }
                            break;
                        case Operation.RemoveByPrice:
                            var removeCount=mobile.RemoveByPrice();
                            if (removeCount != 0)
                            {
                                Console.WriteLine("****************************Deleted successfully*************************************");
                            }
                            else
                            {
                                Console.WriteLine("**********************No record found to delete***********************************");
                            }
                            break;
                        case Operation.Exit:
                            break;
                        default: Console.WriteLine("Invalid choice");
                            break;




                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            } while (operation != Operation.Exit);
            void GetData()
            {
                
                Console.Write("\n\nEnter the Name:");
                mobile.Name = Console.ReadLine();
                Console.Write("\n\nEnter the Description:");
                mobile.Description = Console.ReadLine();
                Console.Write("\n\nEnter manufactured by:");
                mobile.ManufacturedBy = Console.ReadLine();
                Console.Write("\n\nEnter the price:");
                //var number=Console.ReadLine()
                bool IsPrice = double.TryParse(Console.ReadLine(), out result);
                if (IsPrice)
                {
                    mobile.Price = result;
                }
                else
                {
                    Console.WriteLine("**********************************Invalid Entry******************************");
                }
                
            }

            
        }
    }
}