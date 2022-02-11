using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class LandController : Controller
    {
        // GET: Land
        public ActionResult Index()
        {
            return View();
        }

        // GET: Land/Details/5
        public ActionResult Details(int id)
        {
            Land land = new Land();
            land.RealEstateID = 2;
            land.Square = 1000;
            return View(land);

            User user = new User();
            user.Email = "test@test.com";
            user.FullName = "Tester Testson";

            Land advertRes = new Land();
            advertRes.RealEstateID = 1;
            advertRes.Date = DateTime.Now;
            advertRes.Title = "Şile'de satılık arsa";
            advertRes.User = user;
            advertRes.RealEstate = land;
            return View(advertRes);

        }

        // GET: Land/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Land/Create
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

        // GET: Land/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Land/Edit/5
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

        // GET: Land/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Land/Delete/5
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
