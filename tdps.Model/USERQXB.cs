using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����USERQXB ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class USERQXB
	{
		public USERQXB()
		{}
		#region Model
		private string _dlzh;
		private string _qxbm;
        private string _nsrsbh;

        public string NSRSBH
        {
            get { return _nsrsbh; }
            set { _nsrsbh = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string DLZH
		{
			set{ _dlzh=value;}
			get{return _dlzh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QXBM
		{
			set{ _qxbm=value;}
			get{return _qxbm;}
		}
		#endregion Model

	}
}

