using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����DM_YHQX ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DM_YHQX
	{
		public DM_YHQX()
		{}
		#region Model
		private string _qxbm;
		private string _qxmc;
        private bool _sfky;
		/// <summary>
		/// 
		/// </summary>
		public string QXBM
		{
			set{ _qxbm=value;}
			get{return _qxbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QXMC
		{
			set{ _qxmc=value;}
			get{return _qxmc;}
		}

        public bool SFKY
        {
            set { _sfky = value; }
            get { return _sfky; }
        }
		#endregion Model

	}
}

