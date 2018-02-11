using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类UserFunction 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class UserFunction
	{
		public UserFunction()
		{}
		#region Model
		private int _id;
		private string _nsrsbh;
		private string _dlzh;
		private string _gnbh;
        private string _sfky;
        private string _sfbx;
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
		public string DLZH
		{
			set{ _dlzh=value;}
			get{return _dlzh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GNBH
		{
			set{ _gnbh=value;}
			get{return _gnbh;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string SFKY
		{
			set{ _sfky=value;}
			get{return _sfky;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SFBX
		{
			set{ _sfbx=value;}
			get{return _sfbx;}
		}
		#endregion Model

	}
}

