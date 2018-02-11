using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类UserInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class UserInfo
	{
		public UserInfo()
		{}

        private string _sbmm;

        public string SBMM
        {
            set { _sbmm = value; }
            get { return _sbmm; }
        }

		#region Model
		private string _dlzh;
		private string _dlmm;
		private string _nsrsbh;
		private string _cwjsbm;
		private string _nsrmc;
		private string _zsxm;
		private string _xb;
		private string _sjhm;
		private string _qq;
		private string _sfzhm;
		private string _email;
		private string _yzbm;
		private string _dz;
		private string _tjsj;
        private string _dlsj;
        private string _dlzt;

        public string DLZT
        {
            get { return _dlzt; }
            set { _dlzt = value; }
        }
        private string _dlcs;

        public string DLCS
        {
            get { return _dlcs; }
            set { _dlcs = value; }
        }

        public string DLSJ
        {
            get { return _dlsj; }
            set { _dlsj = value; }
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
		public string DLMM
		{
			set{ _dlmm=value;}
			get{return _dlmm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NSRSBH
		{
			set{ _nsrsbh=value;}
			get{return _nsrsbh;}
		}
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
		public string NSRMC
		{
			set{ _nsrmc=value;}
			get{return _nsrmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZSXM
		{
			set{ _zsxm=value;}
			get{return _zsxm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XB
		{
			set{ _xb=value;}
			get{return _xb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SJHM
		{
			set{ _sjhm=value;}
			get{return _sjhm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SFZHM
		{
			set{ _sfzhm=value;}
			get{return _sfzhm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YZBM
		{
			set{ _yzbm=value;}
			get{return _yzbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DZ
		{
			set{ _dz=value;}
			get{return _dz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TJSJ
		{
			set{ _tjsj=value;}
			get{return _tjsj;}
		}
		#endregion Model

	}
}

