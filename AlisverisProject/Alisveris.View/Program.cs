using System;
using Alisveris.Entity;
using Alisveris.ORM;

namespace Alisveris.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Kategori k = new Kategori();
            k.ID = 1;
            k.ad = "Elektronik";
            // KategoriORM.Current.Insert()

            Satici s = new Satici();
            s.ad = "Furkan";

            s.ID = SaticiORM.Current.Insert(s);

            Degerlendirme d = new Degerlendirme();
            d.ID = 1;
            d.Yildiz = 5;

            Urun u = new Urun();
            u.ID = 1;
            u.Kategori = k;
            u.Satici = s;
            u.Degerlendirme = d;

            UrunORM.Current.Insert(u);
        }
    }
}
