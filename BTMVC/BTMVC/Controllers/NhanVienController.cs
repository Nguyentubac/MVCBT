using BTMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTMVC.Controllers
{
    public class NhanVienController : Controller
    {   public static List<NhanVien> listNV = new List<NhanVien>();
        // GET: NhanVien
        public ActionResult Index()
        {
            return View(listNV);
        }
        public ActionResult Find_Gender_FeMale(string Gender)
        {
            var nv_nu = listNV.FindAll(u => u.Gender == "Female");
            return View(nv_nu.ToList());
        }


        // GET: NhanVien/Details/5
        public ActionResult Details(int id)
        {   
            NhanVien nhanVien = new NhanVien();
            nhanVien = listNV.FirstOrDefault(u => u.Id == id);
            if(nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien nv)
        {
            try
            {
                if (listNV.Count > 0)
                {
                    nv.Id = listNV.Max(x => x.Id) + 1;
                }
                else
                {
                    nv.Id = 1;
                }
                listNV.Add(nv);
                return RedirectToAction("Index");
            }
            catch
            {   
                return View(nv);
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien = listNV.FirstOrDefault(u => u.Id == id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhanVien nv)
        {
            try
            {
                NhanVien exist = listNV.FirstOrDefault(u => u.Id == id);
                if (exist == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    exist.Id = nv.Id;
                    exist.Name = nv.Name;
                    exist.Phone = nv.Phone;
                    exist.Birth = nv.Birth;
                    exist.Gender = nv.Gender;
                    exist.SalaryCoefficient = nv.SalaryCoefficient;
                    exist.Salary = nv.Salary;
                    return RedirectToAction("Index");
                }
                // TODO: Add update logic here


            }
            catch
            {
                return View(nv);
            }

        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            NhanVien exist = listNV.FirstOrDefault(u => u.Id == id);
            if (exist == null)
            {
                return HttpNotFound();
            }
            else
            {
                listNV.Remove(exist);
            }
            return View();
        }

        // POST: NhanVien/Delete/5
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
