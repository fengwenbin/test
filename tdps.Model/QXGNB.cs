using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类QXGNB 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class QXGNB
	{
		public QXGNB()
		{}
		#region Model
		private string _bh;
        private string _gnbh;
		private string _qxbh;
        private string _sfky;
		private string _cjr;
		private string _cjsj;
		private string _xgr;
		private string _xgsj;

        private string _czlx;//1=insert,0=delete

        public string CZLX
        {
            set { _czlx = value; }
            get { return _czlx; }
        }

		/// <summary>
		/// 
		/// </summary>
        public string BH
		{
			set{ _bh=value;}
			get{return _bh;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string GNBH
		{
			set{ _gnbh=value;}
			get{return _gnbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QXBH
		{
			set{ _qxbh=value;}
			get{return _qxbh;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string SFKY
		{
			set{ _sfky=value;}
			get{return _sfky;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CJR
		{
			set{ _cjr=value;}
			get{return _cjr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CJSJ
		{
			set{ _cjsj=value;}
			get{return _cjsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XGR
		{
			set{ _xgr=value;}
			get{return _xgr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XGSJ
		{
			set{ _xgsj=value;}
			get{return _xgsj;}
		}
		#endregion Model

	}
}

