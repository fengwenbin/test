using System;
namespace tdps.Model
{
	/// <summary>
	/// 实体类HDXX 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class HDXX
	{
		public HDXX()
		{}
		#region Model
		private string _nsrsbh;
		private string _filename;
		private string _hdxxxml;
        private string _gxsj;

        public string GXSJ
        {
            get { return _gxsj; }
            set { _gxsj = value; }
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
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HDXXXML
		{
			set{ _hdxxxml=value;}
			get{return _hdxxxml;}
		}
        /// <summary>
        /// 税种分类
        /// </summary>
        public int SZFL { get; set; }
		#endregion Model

	}
}

