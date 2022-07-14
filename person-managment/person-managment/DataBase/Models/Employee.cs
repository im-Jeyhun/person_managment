using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.DataBase.Models
{
    internal class Employee
    {
        private static int _idcounter = 1;
        private int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string FinCode { get; set; }
        public string Email { get; set; }

        public Employee()
        {

        }

    }
}
