using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class LaysController : Controller
    {
        // GET: Lays
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult L1()
        {
            List<IndexModel> indexModels = new List<IndexModel>();
            indexModels.Add(new IndexModel { Id = 12, Name = "huahua" });
            indexModels.Add(new IndexModel { Id = 68, Name = "xiaoQiang" });
            indexModels.Add(new IndexModel { Id = 39, Name = "Ming" });
            indexModels.Add(new IndexModel { Id = 6, Name = "MLXG" });
            
            return View(indexModels);
        }
    }
}