using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类SBCLBLL 的摘要说明。
	/// </summary>
	public partial class SBCLBLL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(tdps.Model.SBCL model)
		{
            return dal.Exists(model);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tdps.Model.SBCL model,object trans)
        {
            dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tdps.Model.SBCL model, object trans)
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
        //
        public void Delete(string where, object trans)
        {
            dal.Delete(where, trans);
        }


         /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tdps.Model.SBCL GetModelBySBXXID(int SBXXID)
        {
            return dal.GetModelBySBXXID(SBXXID);
        }

		#endregion  成员方法
	}
}

