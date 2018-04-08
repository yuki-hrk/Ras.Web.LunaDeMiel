using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Mariage
{
	/// <summary>
	/// 食べ合わせ新規登録ビューモデル
	/// </summary>
	public class MariageRegistViewModel
	{
		/// <summary> 商品名 </summary>
		public string ProductName { get; set; }

		/// <summary> はちみつ区分値 </summary>
		public int HoneyType { get; set; }

		/// <summary> 国ID </summary>
		public int CountryId { get; set; }

		/// <summary> 地域名 </summary>
		public string MunicipalName { get; set; }

		/// <summary> 食品名 </summary>
		public string FoodName { get; set; }

		/// <summary> 説明 </summary>
		public string Content { get; set; }

		/// <summary> コメント </summary>
		public string Comment { get; set; }
    }
}