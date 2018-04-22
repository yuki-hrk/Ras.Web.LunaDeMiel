using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Knowledge
{
	/// <summary>
	/// 基礎知識勉強画面ビューモデル
	/// </summary>
	public class KnowledgeStudyViewModel
	{
		/// <summary> タイトル </summary>
		public string Title { get; set; }

		/// <summary> 内容 (前半)</summary>
		public string ContentFirst { get; set; }

		/// <summary> 内容(後半) </summary>
		public string ContentEnd { get; set; }

		/// <summary> キーワード </summary>
		public string Keyword { get; set; }

		/// <summary> 画像 </summary>
		public HttpPostedFileBase Image { get; set; }
	}
}