using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DM_DJZCLX ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DM_DJZCLX
	{
		public DM_DJZCLX()
		{}
		#region Model
		private string _djzclx_dm;
		private string _djzclx_mc;
		private string _djzclx_zl_dm;
		/// <summary>
		/// 
		/// </summary>
		public string djzclx_dm
		{
			set{ _djzclx_dm=value;}
			get{return _djzclx_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string djzclx_mc
		{
			set{ _djzclx_mc=value;}
			get{return _djzclx_mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string djzclx_zl_dm
		{
			set{ _djzclx_zl_dm=value;}
			get{return _djzclx_zl_dm;}
		}
		#endregion Model

	}
}

