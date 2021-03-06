﻿using Ras.Web.LuneDeMiel.ViewModels.Knowledge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ras.Web.LuneDeMiel.Controllers
{
    /// <summary>
    /// 基礎知識 機能のコントローラ
    /// </summary>
    public class KnowledgeController : Controller
    {
        // GET: Knowledge
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Regist()
		{
			// モック用
			var model = new KnowledgeRegistViewModel();
			model.Title = "蜂蜜が白く固まるのはなぜ？";
			model.Content = "果糖より<ブドウ糖>の占める割合が多い蜂蜜ほど、結晶しやすくなります。";

			return View("Regist", model);
        }

		/// <summary>
		/// 勉強画面
		/// </summary>
		/// <returns></returns>
		public ActionResult Study()
		{
			// モック用
			var model = new KnowledgeStudyViewModel();
			model.Title = "蜂蜜が白く固まるのはなぜ？";
			model.ContentFirst = "果糖より";
			model.ContentEnd = "の占める割合が多い蜂蜜ほど、結晶しやすくなります。";
			model.Keyword = "ブドウ糖";

			return View("Study", model);
		}
	}
}