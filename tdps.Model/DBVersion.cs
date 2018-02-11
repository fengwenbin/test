using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类DBVersion 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class DBVersion
	{
		public DBVersion()
		{}
		#region Model
		private int _version;
		private string _ukeyid;
		/// <summary>
		/// 
		/// </summary>
		public int version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UKeyID
		{
			set{ _ukeyid=value;}
			get{return _ukeyid;}
		}
		#endregion Model

	}
}

