using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DM_YPXH ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DM_YPXH
	{
		public DM_YPXH()
		{}
		#region Model
		private string _ypxh_dm;
		private string _ypxh_mc;
		private string _bz;
		private string _xybz;
		/// <summary>
		/// 
		/// </summary>
		public string ypxh_dm
		{
			set{ _ypxh_dm=value;}
			get{return _ypxh_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ypxh_mc
		{
			set{ _ypxh_mc=value;}
			get{return _ypxh_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bz
		{
			set{ _bz=value;}
			get{return _bz;}
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

