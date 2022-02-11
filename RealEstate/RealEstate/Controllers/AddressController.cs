using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class AddressController : Controller
    {

        public string GetCountries()
        {
            //Liste olarak döndürülen Address nesnelerini jspn objelerine çevirdik.
            //string tipindeki bu json objelerini js ile html içerisine yerleştireceğiz.
            string query = "SELECT * FROM Address;";
            string jsonCountries = JsonConvert.SerializeObject(DbTools.Connection.ListCountry(query));
            return jsonCountry;
        }
        public string GetCities(int )
        {
            //Liste olarak döndürülen Address nesnelerini jspn objelerine çevirdik.
            //string tipindeki bu json objelerini js ile html içerisine yerleştireceğiz.
            string query = "SELECT * FROM Address;";
            string jsonCountries = JsonConvert.SerializeObject(DbTools.Connection.ListCountry(query));
            return jsonCity;
        }
        public string GetTowns()
        {
            //Liste olarak döndürülen Address nesnelerini jspn objelerine çevirdik.
            //string tipindeki bu json objelerini js ile html içerisine yerleştireceğiz.
            string query = "SELECT * FROM Address;";
            string jsonTown = JsonConvert.SerializeObject(DbTools.Connection.ListTown(query));
            return jsonTown;
        }
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
