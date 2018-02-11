/**  版本信息模板在安装目录下，可自行修改。
* DM_TZFJJXZ.cs
*
* 功 能： N/A
* 类 名： DM_TZFJJXZ
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015-01-12 14:39:17   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace tdps.Model
{
	/// <summary>
	/// DM_TZFJJXZ:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_TZFJJXZ
	{
		public DM_TZFJJXZ()
		{}
		#region Model
		private string _tzfjjxz_dm;
		private string _tzfjjxz_mc;
		/// <summary>
		/// 
		/// </summary>
		public string tzfjjxz_dm
		{
			set{ _tzfjjxz_dm=value;}
			get{return _tzfjjxz_dm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tzfjjxz_mc
		{
			set{ _tzfjjxz_mc=value;}
			get{return _tzfjjxz_mc;}
		}
		#endregion Model

	}
}

