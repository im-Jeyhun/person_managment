using person_managment.DataBase.Models;
using person_managment.DataBase.Repository;
using System;
using System.Collections.Generic;

namespace person_managment.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/show-persons");
            Console.WriteLine("/add-person");
            Console.WriteLine("/remove-person");
            Console.WriteLine("/update-person");

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "/show-persons")
                {
                
                    List<Employee> employes = EmployeRepository.GetAll();
                    foreach (Employee employe in employes)
                    {
                        Console.WriteLine(employe);
                    }
                    
                }
                else if (command == "/add-person")
                {
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter surname");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter Father name");
                    string fatherName = Console.ReadLine();
                    Console.WriteLine("Enter Finn");
                    string finn = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    string email = Console.ReadLine();

                    EmployeRepository.Add(name, lastName, fatherName, finn, email);
                }
                else if (command== "/remove-person")
                {
                    Console.WriteLine("Pls enter finn which u want to delete");
                    int id = Convert.ToInt32(Console.ReadLine());
                    EmployeRepository.Remove(id);
                }

            }




        }
    }
}
