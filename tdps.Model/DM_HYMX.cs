using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DM_HYMX ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DM_HYMX
	{
		public DM_HYMX()
		{}
		#region Model
		private string _hymx_dm;
		private string _hymx_mc;
		private string _hymx_jc;
		private string _hydl_dm;
		private string _xybz;
		/// <summary>
		/// 
		/// </summary>
		public string hymx_dm
		{
			set{ _hymx_dm=value;}
			get{return _hymx_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hymx_mc
		{
			set{ _hymx_mc=value;}
			get{return _hymx_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hymx_jc
		{
			set{ _hymx_jc=value;}
			get{return _hymx_jc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hydl_dm
		{
			set{ _hydl_dm=value;}
			get{return _hydl_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xybz
		{
			set{ _xybz=value;}
			get{return _xybz;}
		}
		#endregion Model

	}
}

