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
        private static List<Adress> Adress = new List<Adress>();

        public static Adress Add(string name)
        {
            Adress newAdress = new Adress(name);
            Adress.Add(newAdress);
            return newAdress;

            
        }
        public static void Remove(int targetId)
        {

            foreach (Adress adress in Adress)
            {
                if (adress.Id == targetId)
                {
                    Adress.Remove(adress);
                }
            }
            
        }
        public static void RemoveAt(int targetId)
        {
            for (int i = 0; i < Adress.Count; i++)
            {
                if (Adress[i].Id == targetId)
                {
                    Adress.RemoveAt(i);
                }
            }
            
        }
    }
}
