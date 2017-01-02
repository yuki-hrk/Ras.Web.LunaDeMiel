using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// はちみつ 機能のコントローラ
    /// </summary>
    public class HoneyController : Controller
    {
        // GET: Honey
        public ActionResult Index()
        {
            return View();
        }

        // GET: Honey/Detail?id={id}
        public ActionResult Detail()
        {
            return View();
        }

        // GET: Honey/Edit?id={id}
        public ActionResult Edit()
        {
            return View();
        }

        // GET: Honey/BulkEdit
        public ActionResult BulkEdit()
        {
            return View();
        }

        // GET: Honey/Study
        public ActionResult Study()
        {
            return View();
        }
    }
}