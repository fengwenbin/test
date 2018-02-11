using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类SBXX 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SBXX
	{
		public SBXX()
		{}
		#region Model
		private int _sbxxid;
		private string _dlzh;
		private string _nsrsbh;
		private string _sz;
		private string _sbzlcode;
		private string _sbzlmc;
		private string _ssqq;
		private string _ssqz;
		private string _sbbwj;
		private string _bbzt;
		private string _tbsj;
		private string _sbjszt;
		private string _slsj;
		private string _clsj;
		private string _jssj;
		private string _sbqnf;
		private string _sbqyf;
		private string _filename;
		private int? _sbcs;
		private int _ssqlx;
		private decimal _sbse;
		private string _sheetzt;
        private string _sbfssj;
        private string _dymm;
        private string _sblsh;
        private string _cellversion;
        private string _kprqq;
        private string _kprqz;
        private string _sjbs;
        private string _bbtxcs;
        private string _cwbbfsjg;
        private string _cwbbFileName;

        public string CWBBFileName
        {
            get { return _cwbbFileName; }
            set { _cwbbFileName = value; }
        }

        /// <summary>
        /// 财务报表发送结果
        /// </summary>
        public string CWBBFSJG
        {
            get { return _cwbbfsjg; }
            set { _cwbbfsjg = value; }
        }

        /// <summary>
        /// 年报参数
        /// </summary>
        public string BBTXCS
        {
            get { return _bbtxcs; }
            set { _bbtxcs = value; }
        }

        public string SJBS
        {
            get { return _sjbs; }
            set { _sjbs = value; }
        }
        public string SBLSH
        {
            get { return _sblsh; }
            set { _sblsh = value; }
        }

        public string DYMM
        {
            get { return _dymm; }
            set { _dymm = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int SBXXID
		{
			set{ _sbxxid=value;}
			get{return _sbxxid;}
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
		public string NSRSBH
		{
			set{ _nsrsbh=value;}
			get{return _nsrsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SZ
		{
			set{ _sz=value;}
			get{return _sz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBZLCODE
		{
			set{ _sbzlcode=value;}
			get{return _sbzlcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBZLMC
		{
			set{ _sbzlmc=value;}
			get{return _sbzlmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SSQQ
		{
			set{ _ssqq=value;}
			get{return _ssqq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SSQZ
		{
			set{ _ssqz=value;}
			get{return _ssqz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBBWJ
		{
			set{ _sbbwj=value;}
			get{return _sbbwj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BBZT
		{
			set{ _bbzt=value;}
			get{return _bbzt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TBSJ
		{
			set{ _tbsj=value;}
			get{return _tbsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBJSZT
		{
			set{ _sbjszt=value;}
			get{return _sbjszt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SLSJ
		{
			set{ _slsj=value;}
			get{return _slsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLSJ
		{
			set{ _clsj=value;}
			get{return _clsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSSJ
		{
			set{ _jssj=value;}
			get{return _jssj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBQNF
		{
			set{ _sbqnf=value;}
			get{return _sbqnf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBQYF
		{
			set{ _sbqyf=value;}
			get{return _sbqyf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SBCS
		{
			set{ _sbcs=value;}
			get{return _sbcs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SSQLX
		{
			set{ _ssqlx=value;}
			get{return _ssqlx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal SBSE
		{
			set{ _sbse=value;}
			get{return _sbse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SheetZT
		{
			set{ _sheetzt=value;}
			get{return _sheetzt;}
		}
        /// <summary>
        /// 申报发送时间
        /// </summary>
        public string SBFSSJ
        {
            get
            {
                return _sbfssj;
            }
            set
            {
                _sbfssj = value;
            }
        }
        /// <summary>
        /// 申报发送时间
        /// </summary>
        public string CELLVERSION
        {
            get
            {
                return _cellversion;
            }
            set
            {
                _cellversion = value;
            }
        }

        /// <summary>
        /// 开票日期起
        /// </summary>
        public string DKFPRQQ
        {
            get
            {
                return _kprqq;
            }
            set
            {
                _kprqq = value;
            }
        }
        /// <summary>
        /// 开票日期止
        /// </summary>
        public string DKFPRQZ
        {
            get
            {
                return _kprqz;
            }
            set
            {
                _kprqz = value;
            }
        }

		#endregion Model

	}
}

