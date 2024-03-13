using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_MobileManagement
{
    internal class MobileValidation
    {
        public void validation(Mobile mobile)
        {
          if (string.IsNullOrEmpty(mobile.Name))
            {
                throw new MobileException("Name field cannot be null or empty");

            }
            if (string.IsNullOrEmpty(mobile.Description))
            {
                throw new MobileException("**********Description field cannot be null or empty**********");

            }
            if (string.IsNullOrEmpty(mobile.ManufacturedBy))
            {
                throw new MobileException("**********ManufacturedBy field cannot be null or empty**********");

            }
            if(mobile.Price<=0)
            {
                throw new MobileException("**********Price must be greater than zero*************");
            }
        }
    }
    internal class MobileException:Exception
    {
       public MobileException(String message):base(message)
        { 
        }
    }

}
