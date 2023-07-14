using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            var allItem = Departmentlist.GetAll();
            return View(allItem);
        }


        [HttpGet]
        public ActionResult addEdit(int? id)

        {
            Department Department = new Department();
            if (id.HasValue)
            {
                Department = Departmentlist.GetById(id.Value);

            }



            return View(Department);
        }
        [HttpPost]
        public ActionResult addEdit(Department model)

        {
            if (model.Id == 0)
            {
                Departmentlist.Add(model);
            }
            else
            {
                Departmentlist.Update(model.Id, model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)

        {

            if (id.HasValue)
            {
                Departmentlist.Delete(id.Value);


            }
            return RedirectToAction("Index");
        }

    }
}