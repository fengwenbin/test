using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类GNMKB 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class GNMKB
	{
		public GNMKB()
		{}
		#region Model
        private string _id=string.Empty;
        private string _gnmc = string.Empty;
        private string _sj = string.Empty;
        private string _sfky = string.Empty;
        private string _sfbx = string.Empty;
        private string _swjgt = string.Empty;
        private string _gnbh = string.Empty;
        private string _czlx = string.Empty;//1：更新 0：新增
        private string _nsrsbh = string.Empty;

        public string NSRSBH
        {
            get { return _nsrsbh; }
            set { _nsrsbh = value; }
        }

        /// <summary>
        /// 1：更新 0：新增
        /// </summary>
        public string CZLX
        {
            set { _czlx = value; }
            get { return _czlx; }
        }
		/// <summary>
		/// 
		/// </summary>
        public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GNMC
		{
			set{ _gnmc=value;}
			get{return _gnmc;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string SJ
		{
			set{ _sj=value;}
			get{return _sj;}
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
        public string SFBX
		{
			set{ _sfbx=value;}
			get{return _sfbx;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string SWJGT
		{
			set{ _swjgt=value;}
			get{return _swjgt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GNBH
		{
			set{ _gnbh=value;}
			get{return _gnbh;}
		}
		#endregion Model

	}
}

