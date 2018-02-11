using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类GSKHYH 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class GSKHYH
	{
		public GSKHYH()
		{}
		#region Model
		private string _nsrsbh;
		private string _khzh;
		private string _khyhzl;
		private string _khyh;
		private int? _isdefault;
		private string _khyhmc;
		private string _khyhzlmc;
		/// <summary>
		/// 
		/// </summary>
		public string NSRSBH
		{
			set{ _nsrsbh=value;}
			get{return _nsrsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHZH
		{
			set{ _khzh=value;}
			get{return _khzh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHYHZL
		{
			set{ _khyhzl=value;}
			get{return _khyhzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHYH
		{
			set{ _khyh=value;}
			get{return _khyh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDefault
		{
			set{ _isdefault=value;}
			get{return _isdefault;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHYHMC
		{
			set{ _khyhmc=value;}
			get{return _khyhmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHYHZLMC
		{
			set{ _khyhzlmc=value;}
			get{return _khyhzlmc;}
		}
		#endregion Model

	}
}

