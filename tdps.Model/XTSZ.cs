using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����XTSZ ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class XTSZ
	{
		public XTSZ()
		{}
		#region Model
		private string _xtbbh;
		private string _gxsj;
		/// <summary>
		/// 
		/// </summary>
		public string XTBBH
		{
			set{ _xtbbh=value;}
			get{return _xtbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GXSJ
		{
			set{ _gxsj=value;}
			get{return _gxsj;}
		}
		#endregion Model

	}
}

