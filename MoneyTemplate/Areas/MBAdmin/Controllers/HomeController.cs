using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyTemplate.Areas.MBAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: MBAdmin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}