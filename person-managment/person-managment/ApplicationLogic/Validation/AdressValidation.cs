using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.ApplicationLogic.Validation
{
    internal  static class AdressValidation
    {
        public static  bool IsValidAdress(string name)
        {
            if(Validation.IsLengthBetween(name,5,50))
            {
                return true;
            }
            Console.WriteLine("Adress name's length should be greater than 5 and less than 50");
            return false;
        }
    }
}
