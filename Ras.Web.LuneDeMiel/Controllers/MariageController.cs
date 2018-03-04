using Ras.Web.LuneDeMiel.ViewModels.Mariage;
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
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Regist()
		{
			var model = new MariageRegistViewModel()
			{
				ProductName = "ギリシャ　タイム",
				HoneyType = 1,
				CountryId = 1,
				MunicipalName = "ケファロニア島",
				FoodName = "紅茶",
				Countent = "●紅茶：XXXml\n●はちみつ：XXXmg\n●ミント葉：X枚",
				Comment = "味・甘み・香り・余韻のすべてに感じる力強さがあり、バランスの整ったはちみつでタイムの持つ清涼感も感じられる。"
			};

			return View("regist", model);
		}

    }
}