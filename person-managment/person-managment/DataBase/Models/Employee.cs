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
        public int Id { get; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string FinCode { get; set; }
        public string Email { get; set; }

        public Employee(string name,string latsname,string fathername,string fincode,string email)
        {
            Id = _idcounter;
            _idcounter++;
            Name = name;
            Lastname = latsname;
            FatherName = fathername;
            FinCode = fincode;
            Email = email;
        }

    }
}
