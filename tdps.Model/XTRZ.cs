using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类XTRZ 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class XTRZ
	{
		public XTRZ()
		{}
		#region Model
		private int _xh;
		private string _lr;
		private string _rq;
		/// <summary>
		/// 
		/// </summary>
		public int XH
		{
			set{ _xh=value;}
			get{return _xh;}
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
		public string RQ
		{
			set{ _rq=value;}
			get{return _rq;}
		}
		#endregion Model

	}
}

