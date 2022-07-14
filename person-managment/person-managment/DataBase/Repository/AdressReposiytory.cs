using person_managment.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_managment.DataBase.Repository
{
    internal class AdressReposiytory
    {
        private static List<Adress> _adresses = new List<Adress>();
        

        public static Adress Add(string name)
        {
            Adress newAdress = new Adress(name);
            _adresses.Add(newAdress);
            return newAdress;

            
        }
        public static void Remove(int targetId)
        {

            foreach (Adress adress in _adresses)
            {
                if (adress.Id == targetId)
                {
                    _adresses.Remove(adress);
                }
            }
            
        }
        public static void RemoveAt(int targetId)
        {
            for (int i = 0; i < _adresses.Count; i++)
            {
                if (_adresses[i].Id == targetId)
                {
                    _adresses.RemoveAt(i);
                }
            }
            
        }
        public static Adress Update( int id ,string name)
        {
            Adress adress = GetById(id);

            adress.Name = name;


            return adress;
        }
        public static Adress GetById(int id)
        {
            for (int i = 0; i < _adresses.Count; i++)
            {
                if (_adresses[i].Id == id)
                {
                    return _adresses[i];
                }
            }

            return null;
        }
        public static List<Adress> GetAll()
        {
            return _adresses;
        }
    }
}
