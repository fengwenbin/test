using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类NSRXXBLL 的摘要说明。
	/// </summary>
	public partial class NSRXXBLL
	{
		#region  成员方法
	
		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.NSRXX model, object trans)
		{
			dal.Add(model, trans);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.NSRXX model, object trans)
		{
			dal.Update(model, trans);
		}

        public int UpdateSbmm(string nsrxx,string sbmm)
        {
            return dal.UpdateSBMM(nsrxx, sbmm);
        }

		#endregion  成员方法
	}
}

