using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类XTXX 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class XTXX
	{
		public XTXX()
		{}
		#region Model
		private int _fid;
		private string _fsrq;
		private string _zt;
		private string _lr;
		private string _xxlx;
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
		public string FSRQ
		{
			set{ _fsrq=value;}
			get{return _fsrq;}
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
		public string LR
		{
			set{ _lr=value;}
			get{return _lr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XXLX
		{
			set{ _xxlx=value;}
			get{return _xxlx;}
		}
		#endregion Model

	}
}

