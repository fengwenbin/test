using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����XTRZ ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class XTRZ
	{
		public XTRZ()
		{}
		#region Model
		private int _xh;
		private string _lr;
		private string _rq;
		/// <summary>
		/// 
		/// </summary>
		public int XH
		{
			set{ _xh=value;}
			get{return _xh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LR
		{
			set{ _lr=value;}
			get{return _lr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RQ
		{
			set{ _rq=value;}
			get{return _rq;}
		}
		#endregion Model

	}
}

