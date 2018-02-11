using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类USERQXBBLL 的摘要说明。
	/// </summary>
	public partial class USERQXBBLL
	{
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.USERQXB model,object trans)
		{
			dal.Add(model, trans);
		}


		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string DLZH,string NSRSBH,object trans)
		{
			//该表无主键信息，请自定义主键/条件字段
			dal.Delete(DLZH,NSRSBH,trans);
		}

		
		#endregion  成员方法
	}
}

