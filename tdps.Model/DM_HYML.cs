using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类DM_HYML 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DM_HYML
	{
		public DM_HYML()
		{}
		#region Model
		private string _hyml_dm;
		private string _hyml_mc;
		private string _hyml_jc;
		/// <summary>
		/// 
		/// </summary>
		public string hyml_dm
		{
			set{ _hyml_dm=value;}
			get{return _hyml_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hyml_mc
		{
			set{ _hyml_mc=value;}
			get{return _hyml_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hyml_jc
		{
			set{ _hyml_jc=value;}
			get{return _hyml_jc;}
		}
		#endregion Model

	}
}

