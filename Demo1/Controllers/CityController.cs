using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class CityController : Controller
    {
        public ActionResult Index()
        {
            var itemlist = Citylist.GetAll();
            itemlist.ForEach(x => {
                x.StateName = StateLIst.GetById(x.StateId).Name;

            });

            return View(itemlist);
         }


    [HttpGet]
        public ActionResult addEdit(int? id)
        {
            ViewBag.state = StateLIst.GetAll();

            City City = new City();
            if (id.HasValue)
            {
                City = Citylist.GetById(id.Value);

            }



            return View(City);
        }
        [HttpPost]
        public ActionResult addEdit(City model)

        {
            if (model.Id == 0)
            {
                Citylist.Add(model);
            }
            else
            {
                Citylist.Update(model.Id, model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)

        {

            if (id.HasValue)
            {
                Citylist.Delete(id.Value);


            }
            return RedirectToAction("Index");
        }

    }
}