using System;
using System.Data;
using System.Collections.Generic;
using tdps.Model;
namespace tdps.BLL
{
	/// <summary>
	/// 业务逻辑类GSKHYHBLL 的摘要说明。
	/// </summary>
	public partial class GSKHYHBLL
	{
		
		#region  成员方法
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(tdps.Model.GSKHYH model, object trans)
		{
			dal.Add(model, trans);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(tdps.Model.GSKHYH model, object trans)
		{
			dal.Update(model, trans);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(string NSRSBH, object trans)
		{			
			dal.Delete(NSRSBH, trans);
		}

        /// <summary>
        /// 取消默认
        /// </summary>
        /// <returns></returns>
        public void CancelSFMR(string NSRSBH, object trans)
        {
            dal.CancelSFMR(NSRSBH,trans);
        }

		#endregion  成员方法
	}
}

