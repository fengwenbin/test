using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DM_CWJS ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DM_CWJS
	{
		public DM_CWJS()
		{}
		#region Model
		private string _cwjsbm;
		private string _cwjsmc;
		/// <summary>
		/// 
		/// </summary>
		public string CWJSBM
		{
			set{ _cwjsbm=value;}
			get{return _cwjsbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CWJSMC
		{
			set{ _cwjsmc=value;}
			get{return _cwjsmc;}
		}
		#endregion Model

	}
}

