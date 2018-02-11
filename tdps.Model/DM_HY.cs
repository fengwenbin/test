using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类DM_HY 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DM_HY
	{
		public DM_HY()
		{}
		#region Model
		private string _hy_dm;
		private string _hy_mc;
		private string _hy_jc;
		private string _hydl_dm;
		private string _xybz;
		/// <summary>
		/// 
		/// </summary>
		public string hy_dm
		{
			set{ _hy_dm=value;}
			get{return _hy_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hy_mc
		{
			set{ _hy_mc=value;}
			get{return _hy_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hy_jc
		{
			set{ _hy_jc=value;}
			get{return _hy_jc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hydl_dm
		{
			set{ _hydl_dm=value;}
			get{return _hydl_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xybz
		{
			set{ _xybz=value;}
			get{return _xybz;}
		}
		#endregion Model

	}
}

