using Alisveris.Entity;
using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.ORM
{
    public class SaticiORM : IORM<Satici>
    {
        public bool Delete(Satici entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Satici entity)
        {
            string query = $"INSERT INTO Satici (ad,soyad,adres) VALUES ('{entity.ad}','{entity.soyad}','{entity.adres}');";
            // Veritabanına bağlan.
            // Veritabanında sorguyu çalıştır.

        }
        public List<Satici> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(Satici entity)
        {
            throw new NotImplementedException();
        }
    }
}
