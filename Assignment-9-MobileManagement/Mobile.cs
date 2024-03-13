using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_MobileManagement
{
    
    
    internal class Mobile
    {
        public int MobileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ManufacturedBy { get; set; }
            
        public double Price { get; set; }

        public string ManufacturerName { get; set; }

        public static List<Mobile> MobileList=new List<Mobile>();

        public int AddMobile()
        {
            var nameCount=MobileList.Count(name=>name.Name.ToLower()==Name.ToLower());
            MobileId = MobileList.Count == 0 ? 3000 : MobileList.Max(ID => ID.MobileId) + 1;
            if(nameCount==0)
            {
                MobileList.Add(new Mobile() { MobileId=MobileId,Name=Name,
                    Description=Description,ManufacturedBy=ManufacturedBy,
                    Price=Price});
            }
            return nameCount;

        }
        public List<Mobile> ViewAllMobile()
        {
            return MobileList;
        }
        public List<Mobile>SearchByPrice()
        {
            var SearchByPriceList = MobileList.FindAll(mobilePrice => mobilePrice.Price 
            < MobileList.Max(maxprice => maxprice.Price));
            return SearchByPriceList;
        }
        public List<Mobile>SearchByManufacturer() 
        {
            var SearchByManufacturer = MobileList.FindAll(mobile => mobile.ManufacturedBy.ToLower()
            == ManufacturerName.ToLower());
            return SearchByManufacturer;
        }
        public List <Mobile> ViewByPrice() 
        {
            var  viewByPrice=new List<Mobile>();
            if (MobileList.Count != 0)
            {
                var maxPrice = MobileList.Max(maxprice => maxprice.Price);
                var minPrice = MobileList.Min(minprice => minprice.Price);
                 viewByPrice = MobileList.FindAll(price => price.Price > minPrice && price.Price < maxPrice);
                
            }
            return viewByPrice;

             
            

        }
        public int RemoveByPrice()
        {
            int removeCount=0;
            if (MobileList.Count > 0)
            {
                var maxPrice = MobileList.Max(maxprice => maxprice.Price);
                var minPrice = MobileList.Min(minprice => minprice.Price);
                var count = MobileList.RemoveAll(price => price.Price > minPrice && price.Price < maxPrice);
                removeCount = count;
            }
            return removeCount;
            


        }

    }

}
