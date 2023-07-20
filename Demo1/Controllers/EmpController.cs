using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult Index()
        {
            
            var allItem = Empdblist.GetAll();
            allItem.ForEach(x => {
                x.DepartmentName = Departmentlist.GetById(x.Department).Name;
            });
            return View(allItem);
        }


        [HttpGet]
        public ActionResult addEdit(int? id)

        {
            ViewBag.departments = Departmentlist.GetAll();

            EmployeeDto EmployeeDto = new EmployeeDto();
            if (id.HasValue)
            {
                EmployeeDto = Empdblist.GetById(id.Value);

            }



            return View(EmployeeDto);
        }
        [HttpPost]
        public ActionResult addEdit(EmployeeDto model)

        {
            if (model.Id == 0)
            {
                Empdblist.Add(model);
            }
            else
            {
                Empdblist.Update(model.Id, model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)

        {

            if (id.HasValue)
            {
                Empdblist.Delete(id.Value);


            }
            return RedirectToAction("Index");
        }

    }
}