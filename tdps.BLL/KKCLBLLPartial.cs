using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类KKCLBLL 的摘要说明。
	/// </summary>
	public partial class KKCLBLL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(tdps.Model.KKCL model)
		{
			return dal.Exists( model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.KKCL model,object trans)
		{
			dal.Add(model,trans);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBySQL(string strSql)
        {
            return dal.GetListBySQL(strSql);
        }
		#endregion  成员方法
	}
}

