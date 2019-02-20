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
        public ActionResult Index()
        {
            //return Name
            return View();
        }
        public ActionResult Rea2(FormCollection m)
        {
            string name = m["name"];
            string  id = m["id"];
            return Content(name + "\t" + id);
        }
        
    }
}