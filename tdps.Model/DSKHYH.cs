using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DSKHYH ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DSKHYH
	{
		public DSKHYH()
		{}
		#region Model
		private string _khzh;
		private string _nsrsbh;
		private string _khyhzl;
		private string _khyh;
		/// <summary>
		/// 
		/// </summary>
		public string KHZH
		{
			set{ _khzh=value;}
			get{return _khzh;}
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
		public string KHYHZL
		{
			set{ _khyhzl=value;}
			get{return _khyhzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KHYH
		{
			set{ _khyh=value;}
			get{return _khyh;}
		}
		#endregion Model

	}
}

