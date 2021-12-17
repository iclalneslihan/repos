using System;
using CustomProject.ORM;

namespace customerProject.View
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoriesORM orm = new CategoriesORM();
            List<Categories> kategoriler = orm.Select();
            foreach (var item in kategoriler)
            {
                Console.WriteLine(item.CategoryID + "  " + item.CategoryName);



            }
        }
}
