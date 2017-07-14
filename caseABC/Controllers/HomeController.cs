using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using caseABC.Data.DAO;
using caseABC.Data.IDAO;
using caseABC.Services.Service;
using caseABC.Services.IService;

namespace caseABC.Controllers
{
    public class HomeController : Controller
    {
        private IabcService _abcService;
        public HomeController()
        {
            _abcService = new abcService();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Parcels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parcels/Create
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

        // GET: Parcels/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Parcels/Edit/5
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

        // GET: Parcels/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parcels/Delete/5
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
