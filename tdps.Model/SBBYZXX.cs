using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类SBBYZXX 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SBBYZXX
	{
		public SBBYZXX()
		{}
		#region Model
		private int _sbxxid;
		private int _sheetinx;
		private int _col;
		private int _row;
		private string _errorcontent;
		private int? _type;
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
		public int SheetInx
		{
			set{ _sheetinx=value;}
			get{return _sheetinx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Col
		{
			set{ _col=value;}
			get{return _col;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Row
		{
			set{ _row=value;}
			get{return _row;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ErrorContent
		{
			set{ _errorcontent=value;}
			get{return _errorcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

