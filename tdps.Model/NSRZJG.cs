using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类NSRZJG 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NSRZJG
	{
		public NSRZJG()
		{}
		#region Model
		private string _nsrsbh;
		private string _zjgnsrsbh;
		private string _zjgmc;
		private string _kjzg;
		private string _lxdh;
		private string _nd;
		private decimal? _srze;
		private decimal? _gzze;
		private decimal? _zcze;
		private decimal? _hj;
        private string _qdzt;
        /// <summary>
        /// 
        /// </summary>
        public string QDZT
        {
            set { _qdzt = value; }
            get { return _qdzt; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string nsrsbh
		{
			set{ _nsrsbh=value;}
			get{return _nsrsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zjgNsrsbh
		{
			set{ _zjgnsrsbh=value;}
			get{return _zjgnsrsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zjgMc
		{
			set{ _zjgmc=value;}
			get{return _zjgmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string kjzg
		{
			set{ _kjzg=value;}
			get{return _kjzg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LXDH
		{
			set{ _lxdh=value;}
			get{return _lxdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ND
		{
			set{ _nd=value;}
			get{return _nd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SRZE
		{
			set{ _srze=value;}
			get{return _srze;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GZZE
		{
			set{ _gzze=value;}
			get{return _gzze;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZCZE
		{
			set{ _zcze=value;}
			get{return _zcze;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HJ
		{
			set{ _hj=value;}
			get{return _hj;}
		}
		#endregion Model

	}
}

