using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBXXSLGXBBLL 的摘要说明。
	/// </summary>
	public partial class SBXXSLGXBBLL
	{
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBXXSLGXB model,object trans)
		{
			dal.Add(model,trans);
		}

		#endregion  成员方法
	}
}

