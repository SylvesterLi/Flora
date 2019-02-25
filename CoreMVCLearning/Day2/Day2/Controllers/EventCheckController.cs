﻿using Day2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class EventCheckController : Controller
    {
        // GET: EventCheck
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 添加单条数据
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(FormCollection m)
        {
            
            EFDBContext efDB = new EFDBContext();
            Event e = new Event();
            e.Description = m["des"].ToString();
            e.EventTime = Convert.ToDateTime(m["time"]);
            efDB.Events.Add(e);
            efDB.SaveChanges();

            //
            //

            return View();
        }
        public ActionResult Edit(int? id)
        {
            if(id>0)
            {

                return Content("修改成功:"+"ID为\t"+id+"\t的数据");
            }
            else
            {

            
            EFDBContext context = new EFDBContext();
            return View(context.Events);
            }
        }
    }
}