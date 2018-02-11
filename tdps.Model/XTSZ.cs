using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类XTSZ 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class XTSZ
	{
		public XTSZ()
		{}
		#region Model
		private string _xtbbh;
		private string _gxsj;
		/// <summary>
		/// 
		/// </summary>
		public string XTBBH
		{
			set{ _xtbbh=value;}
			get{return _xtbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GXSJ
		{
			set{ _gxsj=value;}
			get{return _gxsj;}
		}
		#endregion Model

	}
}

