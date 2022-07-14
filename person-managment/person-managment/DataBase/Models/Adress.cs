using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.DataBase.Models
{
    internal class Adress
    {
        public string Name { get; set; }
        public  int ID { get; }
        private static int _idcounter = 1;
        public Adress(string name)
        {
            Name = name;
            ID = _idcounter;
            _idcounter++;
        }
    }
}
