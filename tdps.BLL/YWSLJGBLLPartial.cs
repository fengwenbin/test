using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类YWSLJGBLL 的摘要说明。
	/// </summary>
	public partial class YWSLJGBLL
	{
		#region  成员方法
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.YWSLJG model, object trans)
		{
			dal.Add(model,trans);
		}		

		/// <summary>
		/// 得到最大FID
		/// </summary>
		public int GetMaxFID()
		{
            return dal.GetMaxFID();
		}

		#endregion  成员方法
	}
}

