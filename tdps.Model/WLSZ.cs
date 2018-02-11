using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类WLSZ 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class WLSZ
	{
		public WLSZ()
		{}
		#region Model
		private int _fid;
		private string _fwqip;
		private int? _fwqdk;
		private int? _sfmr;
		private int? _sfqynqlj;
        private string _gxsj;
		/// <summary>
		/// 
		/// </summary>
		public int FID
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FWQIP
		{
			set{ _fwqip=value;}
			get{return _fwqip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FWQDK
		{
			set{ _fwqdk=value;}
			get{return _fwqdk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SFMR
		{
			set{ _sfmr=value;}
			get{return _sfmr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SFQYNQLJ
		{
			set{ _sfqynqlj=value;}
			get{return _sfqynqlj;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string GXSJ
        {
            set { _gxsj = value; }
            get { return _gxsj; }
        }
        /// <summary>
        /// 税种分类
        /// </summary>
        public int SZFL { get; set; }
		#endregion Model

	}
}

