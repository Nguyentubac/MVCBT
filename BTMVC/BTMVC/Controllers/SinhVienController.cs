using BTMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.Mvc;

namespace BTMVC.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public static List<SinhVien> list = new List<SinhVien>();
        public ActionResult Index()
        {
            return View(list);
        }
        public ActionResult Login() { 
            return View(); }
        // GET: SinhVien/Details/5
        [HttpPost]
        public ActionResult Login(Login lg)
        {
            if (lg.username != "admin" && lg.password != "admin")
            {
                string msg = string.Format("Welcome User : {0}", lg.username);
                ViewBag.Message = msg;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SinhVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhVien/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SinhVien newsv)
        {
            try
            {
                if (list.Count > 0)
                {
                    newsv.Id = list.Max(x => x.Id) + 1;
                }
                else
                {
                    newsv.Id = 1;
                }
                list.Add(newsv);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(newsv);
            }
        }

        // GET: SinhVien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SinhVien/Edit/5
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

        // GET: SinhVien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SinhVien/Delete/5
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
