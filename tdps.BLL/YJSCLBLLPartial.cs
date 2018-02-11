using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类YJSCLBLL 的摘要说明。
	/// </summary>
	public partial class YJSCLBLL
	{
		#region  成员方法


        public bool Exists(string FileName)
        {
           return dal.Exists(FileName);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.YJSCL model ,object trans)
		{
            dal.Add(model, trans);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.YJSCL model, object trans)
		{
			dal.Update(model,trans);
		}

		#endregion  成员方法
	}
}

