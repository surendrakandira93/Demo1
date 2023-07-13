using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var allItem = DBList.GetAll();
            return View(allItem);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult addEdit(int? id)

        {
            Student student = new Student();
            if (id.HasValue)
            {
                student = DBList.GetById(id.Value);

            }



            return View(student);
        }
        [HttpPost]
        public ActionResult addEdit(Student model)

        {
            if (model.Id == 0)
            {
                DBList.Add(model);
            }
            else
            {
                DBList.Update(model.Id, model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)

        {
           
            if (id.HasValue)
            {
               DBList.Delete(id.Value);


            }
            return RedirectToAction("Index");
        }

    }
}