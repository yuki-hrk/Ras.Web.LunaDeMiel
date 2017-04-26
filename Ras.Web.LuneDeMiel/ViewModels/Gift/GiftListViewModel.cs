using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Gift
{
    /// <summary>
    /// ギフト一覧用ViewModel
    /// </summary>
    public class GiftListViewModel
    {
        /// <summary> 検索条件 </summary>
        public GiftSearchConditionViewModel SearchCondition { get; set; }

        /// <summary> ギフトリスト </summary>
        public IList<GiftViewModel> Gifts { get; set; }
    }
}