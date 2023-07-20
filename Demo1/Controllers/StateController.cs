using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class StateController : Controller
    {
        public ActionResult Index()
        {
            var allItem = StateLIst.GetAll();
            return View(allItem);
        }


        [HttpGet]
        public ActionResult addEdit(int? id)

        {
            State State = new State();
            if (id.HasValue)
            {
                State = StateLIst.GetById(id.Value);

            }



            return View(State);
        }
        [HttpPost]
        public ActionResult addEdit(State model)

        {
            if (model.Id == 0)
            {
                StateLIst.Add(model);
            }
            else
            {
                StateLIst.Update(model.Id, model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)

        {

            if (id.HasValue)
            {
                StateLIst.Delete(id.Value);


            }
            return RedirectToAction("Index");
        }

    }
}