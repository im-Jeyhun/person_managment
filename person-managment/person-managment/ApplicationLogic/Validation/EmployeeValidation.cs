using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.ApplicationLogic.Validation
{
    internal static class EmployeeValidation
    {
        public static bool IsValidFirstName(string firstName)
        {
            if (Validation.IsLengthBetween(firstName, 2, 15))
            {
                return true;
            }

            Console.WriteLine("First name's length should be greater than 2 and less than 15");

            return false;
        }

        public static bool IsValidLastName(string lastName)
        {
            if (Validation.IsLengthBetween(lastName, 4, 17))
            {
                return true;
            }

            Console.WriteLine("Last name's length should be greater than 4 and less than 17");

            return false;
        }
        public static bool IsValidFatherName(string fathername)
        {
            if (Validation.IsLengthBetween(fathername, 2, 15))
            {
                return true;
            }

            Console.WriteLine("Father name's length should be greater than 2 and less than 15");

            return false;

        }
        public static bool IsValidFinCode(string fincode)
        {
            if (fincode.Length == 7)
            {
                return true;
            }


            Console.WriteLine("Fincode's length should be equal to 7");

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            if (Validation.Contains(email, '@'))
            {
                return true;
            }

            Console.WriteLine("Email should contain @ characher.");

            return false;
        }

        public static bool IsValidPassword(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }

            Console.WriteLine("Password is not match");

            return false;
        }


    }
}



