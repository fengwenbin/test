using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DM_PZZL ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DM_PZZL
	{
		public DM_PZZL()
		{}
		#region Model
		private string _pzzl_dm;
		private string _pzzl_mc;
		private string _swws_dm;
		private string _yspz_dm;
		/// <summary>
		/// 
		/// </summary>
		public string pzzl_dm
		{
			set{ _pzzl_dm=value;}
			get{return _pzzl_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pzzl_mc
		{
			set{ _pzzl_mc=value;}
			get{return _pzzl_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string swws_dm
		{
			set{ _swws_dm=value;}
			get{return _swws_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yspz_dm
		{
			set{ _yspz_dm=value;}
			get{return _yspz_dm;}
		}
		#endregion Model

	}
}

