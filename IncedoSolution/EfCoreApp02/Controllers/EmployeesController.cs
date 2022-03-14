  using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreApp02.Models;

namespace EfCoreApp02.Controllers
{
    public class EmployeesController : Controller
    {
        IncedoEmployeeDBContext context = new IncedoEmployeeDBContext();
        // GET: EmployeesController
        public ActionResult Index()
        {
            return View(context.TblEmployees);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.TblEmployees.Single(x=>x.Id==id));
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblEmployee e1)
        {
            try
            {
                context.TblEmployees.Add(e1);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.TblEmployees.Single(x => x.Id == id));
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TblEmployee e)
        {
            try
            {
                context.TblEmployees.Update(e);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.TblEmployees.Single(x => x.Id == id));
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TblEmployee e)
        {
            try
            {
                context.TblEmployees.Remove(e);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
