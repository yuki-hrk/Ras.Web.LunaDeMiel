using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// 食べ合わせ 機能のコントローラ
    /// </summary>
    public class MariageController : Controller
    {
        // GET: Mariage
        public ActionResult Index()
        {
            return View();
        }
    }
}