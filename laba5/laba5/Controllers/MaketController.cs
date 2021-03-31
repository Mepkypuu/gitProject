using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace laba5.Controllers
{
    public class MaketController : Controller
    {
        // GET: Maket
        public ActionResult Index()
        {
            return View("Maket");
        }
    }
}