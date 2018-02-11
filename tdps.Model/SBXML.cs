using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类SBXML 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SBXML
	{
		public SBXML()
		{}
		#region Model
		private int _sbxxid;
		private string _filename;
		private string _sbxmldata;
		/// <summary>
		/// 
		/// </summary>
		public int SBXXID
		{
			set{ _sbxxid=value;}
			get{return _sbxxid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBXMLData
		{
			set{ _sbxmldata=value;}
			get{return _sbxmldata;}
		}
		#endregion Model

	}
}

