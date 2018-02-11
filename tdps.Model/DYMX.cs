using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类DYMX 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DYMX
	{
		public DYMX()
		{}
		#region Model
		private string _sphm;
		private string _jkpzxh;
		private string _dysxh;
		private string _nsrsbh;
		/// <summary>
		/// 
		/// </summary>
		public string SPHM
		{
			set{ _sphm=value;}
			get{return _sphm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JKPZXH
		{
			set{ _jkpzxh=value;}
			get{return _jkpzxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DYSXH
		{
			set{ _dysxh=value;}
			get{return _dysxh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NSRSBH
		{
			set{ _nsrsbh=value;}
			get{return _nsrsbh;}
		}
		#endregion Model

	}
}

