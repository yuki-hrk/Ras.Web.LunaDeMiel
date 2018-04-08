using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Knowladge
{
	public class KnowladgeRegistViewModel
	{
		/// <summary> タイトル </summary>
		public string Title { get; set; }

		/// <summary> 内容 </summary>
		public string Content { get; set; }

		/// <summary> キーワード </summary>
		public string Keyword { get; set; }

		/// <summary> 画像 </summary>
		public HttpPostedFileBase Image { get; set; }
	}
}