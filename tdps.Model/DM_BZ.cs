using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类DM_BZ 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DM_BZ
	{
		public DM_BZ()
		{}
		#region Model
		private string _bz_dm;
		private string _bz_mc;
		private decimal? _bz_dw;
		private decimal? _bz_hl;
		private string _xybz;
		/// <summary>
		/// 
		/// </summary>
		public string bz_dm
		{
			set{ _bz_dm=value;}
			get{return _bz_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bz_mc
		{
			set{ _bz_mc=value;}
			get{return _bz_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? bz_dw
		{
			set{ _bz_dw=value;}
			get{return _bz_dw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? bz_hl
		{
			set{ _bz_hl=value;}
			get{return _bz_hl;}
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

