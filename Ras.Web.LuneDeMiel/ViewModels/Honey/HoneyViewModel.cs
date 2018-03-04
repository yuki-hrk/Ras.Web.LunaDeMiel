using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ras.Web.LuneDeMiel.ViewModels.Honey
{
	public class HoneyViewModel
	{
		/// <summary> ID </summary>
		public int Id { get; set; }
		/// <summary> 商品名 </summary>
		public string Name { get; set; }
		/// <summary> サイズ・値段ディクショナリ </summary>
		public Dictionary<int, int> SizePriceDictionary { get; set; }
		/// <summary> 国ID </summary>
		public int CountryId { get; set; }
		/// <summary> 地域名 </summary>
		public string Municipal { get; set; }
		/// <summary> 養蜂家ID </summary>
		public int CreaterId { get; set; }
		/// <summary> 花の名前 </summary>
		public string FlowerName { get; set; }
		/// <summary> 説明文 </summary>
		public string Comment { get; set; }
		/// <summary> 画像データ </summary>
		public byte[] imageBytes { get; set; }

		/// <summary> 養蜂家選択リスト </summary>
		public Dictionary<int, String> CreaterList { get; set; }
		/// <summary> 国選択リスト </summary>
		public Dictionary<int, String> CountryList { get; set; }

		/// <summary> 税率 </summary>
		public double TaxRate { get; set; }
	}
}