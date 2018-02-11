using System;
namespace tdps.Model
{
	/// <summary>
	/// ʵ����NSRXX ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class NSRXX
	{
		public NSRXX()
		{}
		#region Model
		private string _nsrsbh;
		private string _nsrmc;
		private string _fddbrmc;
		private string _zcdz;
		private string _yydz;
		private string _dhhm;
		private string _yb;
		private string _qyhgdm;
		private string _sbmm;
		private string _filename;
        private string _fdqnsr;
        private string _fdqrqq;
        private string _fdqrqz;
        private string _hzqynsr;
        private string _hzqyrqq;
        private string _hzqyrqz;
        private string _tdpsid;
        private string _cafwqzs;
        private string _dqsj;
        private string _nfydq;
        private string _tsyhlx;
        private string _shxydm;

        public string TSYHLX
        {
            get { return _tsyhlx; }
            set { _tsyhlx = value; }
        }

        public string SHXYDM
        {
            get { return _shxydm; }
            set { _shxydm = value; }
        }

        /// <summary>
        /// ����ѵ���,1�ѹ��ڣ�2��Ѵ߽ɣ�0����
        /// </summary>
        public string NFYDQ
        {
            get { return _nfydq; }
            set { _nfydq = value; }
        }

        /// <summary>
        /// ���������
        /// </summary>
        public string DQSJ
        {
            get { return _dqsj; }
            set { _dqsj = value; }
        }

        /// <summary>
        /// CA����������
        /// </summary>
        public string CAFWQZS
        {
            get { return _cafwqzs; }
            set { _cafwqzs = value; }
        }

        public string TDPSID
        {
            get { return _tdpsid; }
            set { _tdpsid = value; }
        }

		/// <summary>
		/// ��˰��ʶ���
		/// </summary>
		public string NSRSBH
		{
			set{ _nsrsbh=value;}
			get{return _nsrsbh;}
		}
		/// <summary>
        /// ��˰������
		/// </summary>
		public string NSRMC
		{
			set{ _nsrmc=value;}
			get{return _nsrmc;}
		}
		/// <summary>
        /// ��������������
		/// </summary>
		public string FDDBRMC
		{
			set{ _fddbrmc=value;}
			get{return _fddbrmc;}
		}
		/// <summary>
        /// ע���ַ
		/// </summary>
		public string ZCDZ
		{
			set{ _zcdz=value;}
			get{return _zcdz;}
		}
		/// <summary>
        /// Ӫҵ��ַ
		/// </summary>
		public string YYDZ
		{
			set{ _yydz=value;}
			get{return _yydz;}
		}
		/// <summary>
		/// �绰����
		/// </summary>
		public string DHHM
		{
			set{ _dhhm=value;}
			get{return _dhhm;}
		}
		/// <summary>
        /// �ʱ�
		/// </summary>
		public string YB
		{
			set{ _yb=value;}
			get{return _yb;}
		}
		/// <summary>
        /// ��ҵ���ش���
		/// </summary>
		public string QYHGDM
		{
			set{ _qyhgdm=value;}
			get{return _qyhgdm;}
		}
		/// <summary>
        /// �걨����
		/// </summary>
		public string SBMM
		{
			set{ _sbmm=value;}
			get{return _sbmm;}
		}
		/// <summary>
        /// ������Ϣ�ļ���
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
        /// <summary>
        /// ��������˰�ˣ�Y�ǣ�N��
        /// </summary>
        public string FDQNSR
        {
            get
            {
                return _fdqnsr;
            }
            set
            {
                _fdqnsr=value;
            }
        }

        public string fdqrqq
        {
            get
            {
                return _fdqrqq;
            }
            set
            {
                _fdqrqq = value;
            }
        }
        public string fdqrqz
        {
            get
            {
                return _fdqrqz;
            }
            set
            {
                _fdqrqz = value;
            }
        }
        public string hzqynsr
        {
            get
            {
                return _hzqynsr;
            }
            set
            {
                _hzqynsr = value;
            }
        }
        public string hzqyrqq
        {
            get
            {
                return _hzqyrqq;
            }
            set
            {
                _hzqyrqq = value;
            }
        }
        public string hzqyrqz
        {
            get
            {
                return _hzqyrqz;
            }
            set
            {
                _hzqyrqz = value;
            }
        }
		#endregion Model

	}
}

