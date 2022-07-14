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

        public static Employee Add(string name , string lastName , string fatherName , string FINN , string email)
        {
            Employee newemployee = new Employee(name , lastName, fatherName, FINN , email);

            _employees.Add(newemployee);

            return newemployee;
        }

        public static List<Employee> Remove(int targetId)
        {
          
            foreach(Employee employee in _employees)
            {
                if(employee.Id == targetId)
                {
                    _employees.Remove(employee);
                }
            }
           return _employees;
        }

        public static List<Employee> RemoveAt(int targetId)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == targetId)
                {
                    _employees.RemoveAt(i);
                }
            }
            return _employees;
        }


    }
}
