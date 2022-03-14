using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcApp01.Models;

namespace MvcApp01.Controllers
{
    public class CustomersController : Controller
    {
        static CustomerBO context = new CustomerBO();
        public IActionResult Index()
        {
            List<CustomerModel> Customers = context.Customers;
            return View(Customers);
        }
        public IActionResult Details(int id)
        {
            CustomerModel Customers = context.Customers.Single(x=>x.Id==id);
            return View(Customers);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerModel C1)
        {
            context.Customers.Add(C1);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            CustomerModel Customers = context.Customers.Single(x => x.Id == id);
            return View(Customers);
        }
        [HttpPost]
        public IActionResult Edit(CustomerModel C1)
        {
            int index = context.Customers.FindIndex(x => x.Id == C1.Id);
            context.Customers[index] = C1;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            CustomerModel Customers = context.Customers.Single(x => x.Id == id);
            return View(Customers);
        }
        [HttpPost]
        public IActionResult Delete(CustomerModel C1)
        {
            int index = context.Customers.FindIndex(x => x.Id == C1.Id);
            context.Customers.RemoveAt(index);
            return RedirectToAction("Index");
        }
    }
}
