using Alisveris.Entity;
using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alisveris.ORM
{
    public class UrunORM : IORM<Urun>
    {
        private static UrunORM _Current { get; set; }
        public static  UrunORM Current
        {
            get 
            {
                if (UrunORM._Current != null)
                    UrunORM._Current = new UrunORM();
                return UrunORM._Current;
            }
        }
        public bool Delete(Urun entity)
        {
            string query = $"DELETE Urun WHERE ID={entity.ID};";

            //return Tools.ExecuteSQL(query);
        }

        public int Insert(Urun entity)
        {
            string query = $"INSERT INTO Urun (ad,fiyat,KategoriID,SaticiID,DegerlendirmeID) VALUES('{entity.ad}',{entity.fiyat},{entity.Kategori.ID},{entity.Satici.ID},{entity.Degerlendirme.ID});";

            return Tools.ExecuteSQL(query);
        }
        public List<Urun> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(Urun entity)
        {
            string query = $"UPDATE Urun SET ad='{entity.ad}',fiyat={entity.fiyat},Kategori={entity.Kategori.ID},Satici={entity.Satici.ID},Degerlendirme={entity.Degerlendirme.ID} WHERE ID={entity.ID};";

            //return Tools.ExecuteSQL(query);
        }
    }
}
