using person_managment.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.DataBase.Repository
{
    internal class EmployeRepository
    {
        private static List<Employee> _employees = new List<Employee>();

        public static Employee Add(string name, string lastName, string fatherName, string FINN, string email)
        {
            Employee newemployee = new Employee(name, lastName, fatherName, FINN, email);

            _employees.Add(newemployee);

            return newemployee;
        }

        public static void Remove(int targetId)
        {

            foreach (Employee employee in _employees)
            {
                if (employee.Id == targetId)
                {
                    _employees.Remove(employee);
                }
            }

        }

        public static void RemoveAt(int targetId)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == targetId)
                {
                    _employees.RemoveAt(i);
                }
            }
        }

        public static Employee Update(int id, string name, string lastName, string fatherName, string Finn, string email)
        {
            Employee employee = GetById(id);

            employee.Name = name;
            employee.Lastname = lastName;
            employee.FatherName = fatherName;
            employee.FinCode = Finn;
            employee.Email = email;

            return employee;
        }

        public static Employee GetById(int id)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == id)
                {
                    return _employees[i];
                }
            }

            return null;
        }

    }
}
