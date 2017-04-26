using Ras.Web.LuneDeMiel.ViewModels.Gift;
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
            // For mockup
            var listViewModel = new GiftListViewModel
            {
                SearchCondition = new GiftSearchConditionViewModel(),
                Gifts = new List<GiftViewModel>
                {
                    new GiftViewModel
                    {
                        Name = "オレンジとベリーの宝石箱",
                        Price = 1836,
                        Items = new List<GiftItemViewModel>
                        {
                            new GiftItemViewModel
                            {
                                Name = "スペイン　オレンジ"
                            },
                            new GiftItemViewModel
                            {
                                Name = "はちみつコンフィチュール　3種のベリー"
                            }
                        }
                    },
                    new GiftViewModel
                    {
                        Name = "さくらんぼの宝石箱",
                        Price = 4320,
                        Items = new List<GiftItemViewModel>
                        {
                            new GiftItemViewModel
                            {
                                Name = "イタリア　さくらんぼ"
                            },
                            new GiftItemViewModel
                            {
                                Name = "はちみつコンフィチュール　さくらんぼ"
                            }
                        }
                    },
                    new GiftViewModel
                    {
                        Name = "果実の贈りもの（トリオ）",
                        Price = 1836,
                        Items = new List<GiftItemViewModel>
                        {
                            new GiftItemViewModel
                            {
                                Name = "イタリア　さくらんぼ"
                            },
                            new GiftItemViewModel
                            {
                                Name = "はちみつコンフィチュール　さくらんぼ"
                            },
                            new GiftItemViewModel
                            {
                                Name = "はちみつコンフィチュール　3種のベリー"
                            }
                        }
                    }
                }
            };

            return View(listViewModel);
        }
    }
}