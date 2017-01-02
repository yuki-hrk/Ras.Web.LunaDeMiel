using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// ギフト 機能のコントローラ
    /// </summary>
    public class GiftController : Controller
    {
        // GET: Gift
        public ActionResult Index()
        {
            return View();
        }
    }
}