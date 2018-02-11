using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类TZGG 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class TZGG
	{
		public TZGG()
		{}
		#region Model
		private int _fid;
		private string _ggbt;
		private string _fsjg;
		private string _fsrq;
		private string _ydyq;
		private string _zt;
		private string _gglr;
		/// <summary>
		/// 
		/// </summary>
		public int FID
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GGBT
		{
			set{ _ggbt=value;}
			get{return _ggbt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSJG
		{
			set{ _fsjg=value;}
			get{return _fsjg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSRQ
		{
			set{ _fsrq=value;}
			get{return _fsrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YDYQ
		{
			set{ _ydyq=value;}
			get{return _ydyq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZT
		{
			set{ _zt=value;}
			get{return _zt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GGLR
		{
			set{ _gglr=value;}
			get{return _gglr;}
		}
		#endregion Model

	}
}

