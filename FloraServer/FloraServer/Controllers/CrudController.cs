using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FloraServer.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvent(IFormCollection m)
        {
            //拿到 网页上的数据
            //string s = m["EventDescript"];

            //使用DataAnotions方法


            return Content("提交成功");
        }
    }
}