using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类ClientVersion 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ClientVersion
	{
		public ClientVersion()
		{}
		#region Model
		private int _id;
		private string _nsrsbh;
		private string _version;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
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
		public string Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		#endregion Model

	}
}

