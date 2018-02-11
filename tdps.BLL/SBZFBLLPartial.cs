using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBZFBLL 的摘要说明。
	/// </summary>
	public partial class SBZFBLL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(tdps.Model.SBZF model)
		{
			return dal.Exists( model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(tdps.Model.SBZF model,object trans)
		{
            dal.Add(model, trans);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.SBZF model, object trans)
        {
            dal.Update(model, trans);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int SBXXID, object trans)
        {
            dal.Delete(SBXXID, trans);
        }

        /// <summary>
        /// 得到一个实体对象
        /// </summary>
        public tdps.Model.SBZF GetModelBySBXXID(int SBXXID)
        {
           return dal.GetModelBySBXXID(SBXXID);
        }

		#endregion  成员方法
	}
}

