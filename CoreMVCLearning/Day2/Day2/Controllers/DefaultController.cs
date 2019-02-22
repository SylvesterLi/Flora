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
            //在这读取数据库内容
            //并return View(Your Model);
            //在Get方法里展示数据库当前的内容
            IndexModel indexModel = new IndexModel();
            indexModel.Id = 12;
            indexModel.Name = "234safg";
            //return Name
            return View(indexModel);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection m, HttpPostedFileBase fileBase)
        {

            //点击Submit后
            //在Post方法里进行数据库的Update操作
            //这里需要读取当前View展示的东西【数据从Edit(这里传进来)】
            fileBase.SaveAs(Server.MapPath("~/" + fileBase.FileName));
            string name = m["name"];
            string id = m["id"];
            return Content(name + "\t" + id);
        }

    }
}