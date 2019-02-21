using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            //return Name
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection m,HttpPostedFileBase fileBase)
        {
            fileBase.SaveAs(Server.MapPath("~/"+fileBase.FileName));
            string name = m["name"];
            string  id = m["id"];
            return Content(name + "\t" + id);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            IndexModel indexModel = new IndexModel();
            indexModel.Id = 12;
            indexModel.Name = "234safg";
            //return Name
            return View(indexModel);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection m, HttpPostedFileBase fileBase)
        {
            fileBase.SaveAs(Server.MapPath("~/" + fileBase.FileName));
            string name = m["name"];
            string id = m["id"];
            return Content(name + "\t" + id);
        }

    }
}