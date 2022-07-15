using person_managment.ApplicationLogic.Validation;
using person_managment.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.ApplicationLogic
{
    internal class Authentication
    {
        public static void Register()
        {
            string firstName = GetFirstName();
            string lastName = GetLastName();

        }

        public static string GetFirstName ()
        {
            Console.Write("Pls enter name : ");
            string firstName = Console.ReadLine();
            while (!EmployeeValidation.IsValidFirstName(firstName))
            {
                Console.Write("Pls enter name again");
                firstName = Console.ReadLine();
            }
            return firstName;
        } 

        public static string GetLastName()
        {
            Console.Write("Pls enter surname : ");
            string lastName = Console.ReadLine();
            while (!EmployeeValidation.IsValidLastName(lastName))
            {
                Console.Write("Pls enter surname again : ");
                 lastName = Console.ReadLine();
            }
            return lastName;
        }
        public static string GetFatherName()
        {
            Console.Write("Pls enter father name : ");
            string fatherName = Console.ReadLine();
            while (!EmployeeValidation.IsValidFatherName(fatherName))
            {
                Console.Write("Pls enter father name again : ");
                fatherName = Console.ReadLine();

            }
        }
    }
}
