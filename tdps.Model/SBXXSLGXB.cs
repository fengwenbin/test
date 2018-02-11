using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类SBXXSLGXB 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SBXXSLGXB
	{
		public SBXXSLGXB()
		{}
		#region Model
		private int? _fid;
		private int? _sbxxid;
		/// <summary>
		/// 
		/// </summary>
		public int? FID
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SBXXID
		{
			set{ _sbxxid=value;}
			get{return _sbxxid;}
		}
		#endregion Model

	}
}

