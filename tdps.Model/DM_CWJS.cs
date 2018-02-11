using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类DM_CWJS 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DM_CWJS
	{
		public DM_CWJS()
		{}
		#region Model
		private string _cwjsbm;
		private string _cwjsmc;
		/// <summary>
		/// 
		/// </summary>
		public string CWJSBM
		{
			set{ _cwjsbm=value;}
			get{return _cwjsbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CWJSMC
		{
			set{ _cwjsmc=value;}
			get{return _cwjsmc;}
		}
		#endregion Model

	}
}

